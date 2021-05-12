using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageManager : MonoBehaviour
{
    public GameObject[] pages;
    public InputField url;
    public GenEACode gcode;

    public void OpenPage()
    {
        gcode.currentLevel = url.text;
        CloseAll();
        foreach (GameObject page in pages)
        {
            if (page.name == url.text)
                page.SetActive(true);
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
