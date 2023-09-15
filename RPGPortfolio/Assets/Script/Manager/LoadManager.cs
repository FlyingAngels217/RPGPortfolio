using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    public static string nextScene;

    public GameManager _GameManager;
    private DataManager _DataManager;

    private void Start()
    {
        _GameManager = FindObjectOfType<GameManager>();
        _DataManager = _GameManager.SettingDataManager();
        StartCoroutine(LoadScene());
    }

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("Loading");
    }

    IEnumerator LoadScene()
    {
        yield return null;

        // ���¹��� �ε��
        _DataManager.LoadAssetBundle();

        yield return null;
        
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false;
        float timer = 0.0f;

        while (!op.isDone)
        {
            yield return null;
            timer += Time.deltaTime;
            if(op.progress < 0.9f)
            {
                // �ε���
            }
            else
            {
                op.allowSceneActivation = true;
                yield break;
            }
        }
    }

    IEnumerator LoadAssetBundle()
    {
        yield return null;
    }
}
