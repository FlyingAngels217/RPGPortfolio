using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleUI : MonoBehaviour
{
    public Button TitleButton;
    public GameManager _GameManager;

    private void Start()
    {
        TitleButton.onClick.AddListener(Titlebtn);
    }

    private void Titlebtn()
    {
        _GameManager.GameStart();
    }
}
