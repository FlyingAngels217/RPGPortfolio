using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{
    private LoadManager _LoadManager;
    public SceneLoadManager()
    {
        _LoadManager = new LoadManager(/*프로그래스바 값*/);
    }

    public void LoadScene(SCENENAME scene)
    {
        switch (scene)
        {
            case SCENENAME.TITLE:
                break;
            case SCENENAME.LOADING:
                break;
            case SCENENAME.MAIN:
                LoadManager.LoadScene("Game");
                break;
        }
    }
}
