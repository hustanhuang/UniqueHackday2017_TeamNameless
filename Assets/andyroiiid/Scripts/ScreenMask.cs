using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Image))]
public class ScreenMask : MonoBehaviour
{
    private Image _image;

    // 控制 _image 透明度来操作遮蔽
    public float Opacity
    {
        get { return _image.color.a; }
        set
        {
            Color color = _image.color;
            color.a = value;
            _image.color = color;
        }
    }

    void Awake()
    {
        _image = GetComponent<Image>();
    }

    private Tweener _tweener;

    public Tweener Switch(bool on, float duration)
    {
        // 开启 gameObject
        gameObject.SetActive(true);

        if (_tweener != null)
        {
            // 如果已经在渐变，就立刻中止
            _tweener.Kill();
        }
        else
        {
            // 设置 _image 透明度初始值
            Opacity = on ? 0.0f : 1.0f;
        }

        // 设置 _image 透明度目标值
        float endOpacity = on ? 1.0f : 0.0f;

        _tweener = DOTween
            .To(() => Opacity, (x) => Opacity = x, endOpacity, duration)
            .OnComplete(() =>
            {
                // 关闭 gameObject
                gameObject.SetActive(false);
                // 清除 _tweener
                _tweener = null;
            });

        return _tweener;
    }
}
