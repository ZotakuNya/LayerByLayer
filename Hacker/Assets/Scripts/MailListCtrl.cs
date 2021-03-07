using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailListCtrl : MonoBehaviour
{
    public GameObject mainPage;
    public GameObject mission1;

    public void SwitchToMain()
    {
        mainPage.SetActive(true);
        mission1.SetActive(false);
    }
    public void SwitchToM1()
    {
        mainPage.SetActive(false);
        mission1.SetActive(true);
    }
}
