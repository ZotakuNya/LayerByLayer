using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public Text point;
    public GameObject main;
    public GameObject CPU;
    public GameCtrl gc;
    private void Awake()
    {
        ToMain();
    }

    public void ToMain()
    {
        main.SetActive(true);
        CPU.SetActive(false);
    }
    
    public void ToCPU()
    {
        main.SetActive(false);
        CPU.SetActive(true);
    }

    private void Update()
    {
        point.text = gc.point.ToString();
    }
}
