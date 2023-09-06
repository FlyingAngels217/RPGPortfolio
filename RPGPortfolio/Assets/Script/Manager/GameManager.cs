using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    DataManager _DataManager;
    StageManager _StageManager;
    SceneLoadManager _SceneLoadManager;

    //����׿�
    public int DebugRand;

    private void Awake()
    {
        _DataManager = new DataManager();
        _StageManager= new StageManager();
        _SceneLoadManager = new SceneLoadManager();

        DebugRand = Random.Range(0, 99999);
        Debug.Log("���� " + DebugRand);
    }

    public void GameStart()
    {
        _SceneLoadManager.LoadScene(SCENENAME.MAIN);
        Debug.Log("���ӽ��� " + DebugRand);
    }
}
