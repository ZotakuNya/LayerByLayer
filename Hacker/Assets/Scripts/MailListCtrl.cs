using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailListCtrl : MonoBehaviour
{
    public GameObject mainPage;
    public GameObject[] missionList;

    public void SwitchToMain()
    {
        CloseAll();
        mainPage.SetActive(true);
    }
    public void SwitchToM1()
    {
        CloseAll();
        missionList[0].SetActive(true);
    }
    public void SwitchToM2()
    {
        CloseAll();
        missionList[1].SetActive(true);
    }
    public void SwitchToM3()
    {
        CloseAll();
        missionList[2].SetActive(true);
    }
    public void SwitchToM4()
    {
        CloseAll();
        missionList[3].SetActive(true);
    }
    public void SwitchToM5()
    {
        CloseAll();
        missionList[4].SetActive(true);
    }
    public void SwitchToM6()
    {
        CloseAll();
        missionList[5].SetActive(true);
    }
    public void SwitchToM7()
    {
        CloseAll();
        missionList[6].SetActive(true);
    }
    public void SwitchToM8()
    {
        CloseAll();
        missionList[7].SetActive(true);
    }

    public void CloseAll()
    {
        foreach (GameObject mission in missionList)
        {
            mission.SetActive(false);
        }
        mainPage.SetActive(false);
    }
}

