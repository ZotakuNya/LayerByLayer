using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageSwitch : MonoBehaviour
{
    public int currentMode = 0;
    public GameObject graphic;
    public GameObject code;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F12))
        {
            if(currentMode == 0)
            {
                SwitchToCode();
            }
            else
            {
                SwitchToGraphic();
            }
        }
    }

    public void SwitchToGraphic()
    {
        currentMode = 0;
        graphic.SetActive(true);
        code.SetActive(false);
    }

    public void SwitchToCode()
    {
        currentMode = 1;
        graphic.SetActive(false);
        code.SetActive(true);
    }
}
