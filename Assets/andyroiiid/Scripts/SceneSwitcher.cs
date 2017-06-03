using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SceneSwitcher : MonoBehaviour
{
    public static float maskTime = 1.0f;

    public ScreenMask mask;

    private AsyncOperation _asyncOpertaion = null;

    void Start()
    {
        // 进入场景时播放遮蔽从有到无
        mask.Switch(false, maskTime);
    }

    public void Goto(string scene)
    {
        // 如果已经有场景在加载，就不要启动新的异步加载协程
        if (_asyncOpertaion != null)
            return;

        // 启动异步加载协程
        StartCoroutine(LoadSceneAsync(scene));

        // 切换场景前播放遮蔽从无到有
        mask.Switch(true, maskTime).OnComplete(() =>
        {
            // TODO: 这里认为 maskTime 的时间之内场景一定能加载完成
            // 因为异步加载已经完成，这里应该能够瞬间切换
            SceneManager.LoadScene(scene);
        });
    }

    // 异步加载场景
    IEnumerator LoadSceneAsync(string scene)
    {
        _asyncOpertaion = SceneManager.LoadSceneAsync(scene, LoadSceneMode.Single);
        // 加载完成后等待遮蔽完成再切换场景
        _asyncOpertaion.allowSceneActivation = false;
        yield return _asyncOpertaion;
    }
}
