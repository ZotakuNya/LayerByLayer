using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sql1Level : MonoBehaviour
{
    public InputField username;
    public InputField passwd;

    public string[] unames;
    public string[] passwds;

    public ErrorHandle eh;
    public GameCtrl gc;

    public void Login()
    {
        int i = 0;
        for (i = 0; i < unames.Length; i++)
        {
            if(unames[i] == username.text)
            {
                if (passwds[i] == passwd.text)
                    eh.PassReport("请使用注入方法通关");
                else if (passwd.text == "2'or'1")
                {
                    gc.mails[5].SetActive(true);
                    eh.PassReport("通关!请查收邮件");
                }
                else
                    eh.ErrorReport("密码错误");
                break;
            }
        }
        if (i == unames.Length)
            eh.ErrorReport("用户名不存在");
    }
}
