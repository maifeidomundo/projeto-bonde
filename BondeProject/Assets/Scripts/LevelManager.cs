using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance = null;

    void Start() {
        if (instance == null) {
            instance = this;
        }
    }

    [SerializeField]
    public UIComponents uiComponents;

    public void ShowLevelCompletePanel()
    {
        uiComponents.LCpanel.levelcompletepanel.SetActive(true);

    }
}