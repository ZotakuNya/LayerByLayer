﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ErrorHandle : MonoBehaviour
{
    public Text content;
    public float speed;
    public Image bg;
    public Color ErrorColor;
    public Color SuccessColor;

    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void ErrorReport(string text)
    {
        bg.color = ErrorColor;
        content.text = "Error: " + text;
        StartCoroutine(IEApper());
    }

    public void PassReport(string text)
    {
        bg.color = SuccessColor;
        content.text = "Success: " + text;
        StartCoroutine(IEApper());
    }

    public void HideError()
    {
        StartCoroutine(IEDisapper());
    }

    private IEnumerator IEApper()
    {
        while (_rectTransform.anchoredPosition3D.y > 0)
        {
            _rectTransform.anchoredPosition3D += Vector3.down * (speed * Time.deltaTime);
            yield return 0;
        }
    }
    
    private IEnumerator IEDisapper()
    {
        while (_rectTransform.anchoredPosition3D.y < 80)
        {
            _rectTransform.anchoredPosition3D += Vector3.up * (speed * Time.deltaTime);
            yield return 0;
        }
    }
}
