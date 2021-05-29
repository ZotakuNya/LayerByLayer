using UnityEngine;
using UnityEngine.UI;

public class IntroCtrl : MonoBehaviour
{
    public GameObject content;
    public Text message;
    public void Disappear()
    {
        content.SetActive(false);
    }

    public void ShowMessage(string data)
    {
        content.SetActive(true);
        message.text = data;
    }
}
