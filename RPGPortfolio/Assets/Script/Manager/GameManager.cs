using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    DataManager _DataManager;
    StageManager _StageManager;
    SceneManager _SceneManager;

    public GameManager()
    {
        _DataManager = new DataManager();
        _StageManager= new StageManager();
        _SceneManager= new SceneManager();
    }

    public void GameStart()
    {

    }
}
