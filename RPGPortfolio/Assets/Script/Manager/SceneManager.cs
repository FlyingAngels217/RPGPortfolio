using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private LoadManager _LoadManager;

    public SceneManager()
    {
        _LoadManager = new LoadManager();
    }

    public void LoadScene(SCENENAME scene)
    {
        
    }
}
