using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commander : MonoBehaviour
{
    public GameObject line;
    public int currentline = 0;

    private void Start()
    {
        Instantiate(line, transform);
    }

    public void ProcessCmd(string cmd)
    {
        currentline += 1;
        GameObject Go = Instantiate(line, transform);
        Go.GetComponent<RectTransform>().anchoredPosition3D -= new Vector3(0, 24 * currentline, 0);
    }
}
