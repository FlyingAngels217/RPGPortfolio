using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{
    private DataManager _DataManager;

    public SceneLoadManager(DataManager dataManager)
    {
        _DataManager = dataManager;
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
