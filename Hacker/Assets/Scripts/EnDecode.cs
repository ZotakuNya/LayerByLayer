using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnDecode : MonoBehaviour
{
    public InputField input;
    public InputField output;

    public void Encode()
    {
        byte[] bytes = System.Text.Encoding.Default.GetBytes(input.text);
        output.text = Convert.ToBase64String(bytes);
    }

    public void Decode()
    {
        byte[] outputb = Convert.FromBase64String(input.text);
        output.text = System.Text.Encoding.Default.GetString(outputb);
    }
}
