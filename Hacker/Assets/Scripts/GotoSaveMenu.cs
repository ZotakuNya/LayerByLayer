using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoSaveMenu : MonoBehaviour
{
    public GameObject saveMenu;

    void Finish()
    {
        saveMenu.SetActive(true);
        transform.parent.gameObject.SetActive(false);
    }
}
