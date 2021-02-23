using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BtnCtrl : MonoBehaviour
{
    public GameObject loading;
    public GameObject setting;
    public GameObject start;
    
    public void Exit()
    {
        Application.Quit();
    }

    public void GotoSetting()
    {
        setting.SetActive(true);
    }

    public void GotoLoading()
    {
        loading.SetActive(true);
        start.SetActive(false);
    }

    public void ExitSetting()
    {
        setting.SetActive(false);
    }
}
