using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendCmd : MonoBehaviour
{
    public InputField cmd;
    public Commander terminal;

    private void Awake()
    {
        terminal = transform.parent.parent.GetComponent<Commander>();
        cmd.ActivateInputField();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if (!cmd.isFocused)
            {
                terminal.ProcessCmd(cmd.text);
                cmd.enabled = false;
                this.enabled = false;
            }
        }    
    }
}
