using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class ScriptsDisplayer : MonoBehaviour
{
    public TextMeshProUGUI text;

    public float sepTime = 1.0f;
    public float switchTime = 1.0f;
    public float onTime = 2.0f;

    public TextAsset json;
    [System.Serializable]
    public class Scripts
    {
        public string[] scripts;
        public static Scripts LoadJson(TextAsset json)
        {
            return JsonUtility.FromJson<Scripts>(json.text);
        }
    }
    private string[] _texts;

    private int _progess = 0;

    void Start()
    {
        _texts = Scripts.LoadJson(json).scripts;

        text.text = string.Empty;
        SetAlpha(text, 0.0f);

        StartCoroutine(WaitAndChangeText());
    }

    private static float GetAlpha(TextMeshProUGUI t)
    {
        return t.color.a;
    }

    private static void SetAlpha(TextMeshProUGUI t, float x)
    {
        Color c = t.color;
        c.a = x;
        t.color = c;
    }

    public void ChangeText()
    {
        Debug.Log("set text " + _texts[_progess]);
        text.SetText(_texts[_progess++]);

        Sequence seq = DOTween.Sequence();
        seq.Append(DOTween.To(() => GetAlpha(text), (x) => SetAlpha(text, x), 1, switchTime));
        seq.AppendInterval(onTime);
        seq.Append(DOTween.To(() => GetAlpha(text), (x) => SetAlpha(text, x), 0, switchTime));

        if (_progess == _texts.Length)
            seq.AppendCallback(() => Debug.Log("end of scripts"));
        else
            seq.AppendCallback(() => StartCoroutine(WaitAndChangeText()));
    }

    IEnumerator WaitAndChangeText()
    {
        yield return new WaitForSeconds(sepTime);
        ChangeText();
    }
}
