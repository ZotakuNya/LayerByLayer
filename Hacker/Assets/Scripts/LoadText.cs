using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
    public Text text;
    void Start()
    {
        GetComponent<InputField>().text = text.text;
    }
}
