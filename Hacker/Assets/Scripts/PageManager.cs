using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageManager : MonoBehaviour
{
    public GameObject[] pages;
    public InputField url;
    public GenEACode gcode;
    public ErrorHandle eh;
    public GameCtrl gc;

    public void OpenPage()
    {
        gcode.currentLevel = url.text;
        CloseAll();
        foreach (GameObject page in pages)
        {
            if (page.name == url.text)
            {
                page.SetActive(true);
            }
            if (url.text.Contains("Sql2") && (url.text != "Sql2") && (page.name == "Sql2"))
            {
                if(url.text == "Sql2?user=admin' or 1='1")
                {
                    page.transform.GetChild(0).gameObject.SetActive(false);
                    page.transform.GetChild(1).gameObject.SetActive(true);
                    eh.PassReport("注入成功");
                    gc.mails[6].SetActive(true);
                    page.SetActive(true);
                }
                else
                {
                    eh.ErrorReport("注入失败");
                }
            }
            if (url.text == "")
                OpenPage0();
        }
    }

    public void CloseAll()
    {
        foreach(GameObject page in pages)
        {
            page.SetActive(false);
        }
    }

    public void OpenPage0()
    {
        pages[0].SetActive(true);
    }

    public void OpenPage1()
    {
        pages[1].SetActive(true);
    }

    public void OpenTrap()
    {
        pages[5].SetActive(true);
    }
}
