using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
 
public class LongPressBtn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //按下多长时间算长按
    public float timeLongPress = 0.5f;
    //是否按下
    private bool isPointerDown = false;
    //按下时刻
    private float timePointerDown = 0;
    //回调方法
    public UnityEvent MethodCallBack;
    
    private Image btnImage;
    private Color originColor;

    private void Start()
    {
        btnImage = GetComponent<Image>();
        originColor = btnImage.color;
    }

    void Update()
    {
        float span = Time.time - timePointerDown;
        if (isPointerDown)
        {
            btnImage.color = new Color(
                btnImage.color.r - Time.deltaTime / 2, 
                btnImage.color.g - Time.deltaTime / 2, 
                btnImage.color.b - Time.deltaTime / 2, 
                btnImage.color.a);
        }
        if (isPointerDown && span > timeLongPress)
        {
            MethodCallBack.Invoke();
            btnImage.color = originColor;
            timePointerDown = 0;
            isPointerDown = false;
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isPointerDown = true;
        timePointerDown = Time.time;
        //MethodCallBack.Invoke();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isPointerDown = false;
        btnImage.color = originColor;
        timePointerDown = 0;
    }
}