using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.UI;
using UnityEngine.UIElements;

public class LoadManager : MonoBehaviour
{
    public static string nextScene;

    private void Start()
    {
        StartCoroutine(LoadScene());
    }

    public static void LoadScene(string sceneName)
    {
        nextScene= sceneName;
        SceneManager.LoadScene("LoadingScene");
    }

    IEnumerator LoadScene()
    {
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
}
