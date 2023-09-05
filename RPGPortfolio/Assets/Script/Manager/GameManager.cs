using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    DataManager _DataManager;
    StageManager _StageManager;
    SceneLoadManager _SceneLoadManager;

    public GameManager()
    {
        _DataManager = new DataManager();
        _StageManager= new StageManager();
        _SceneLoadManager = new SceneLoadManager();
    }

    public void GameStart()
    {
        _SceneLoadManager.LoadScene(SCENENAME.MAIN);
    }
}
