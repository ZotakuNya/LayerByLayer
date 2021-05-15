using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code1Level : MonoBehaviour
{
    public InputField uname;
    public InputField passwd;

    public ErrorHandle eh;

    public void Login()
    {
        if ((uname.text == "admin") && (passwd.text == "abcd"))
        {
            //TODO:New Level
            eh.PassReport("成功了,请查收新邮件");
        }
        else
        {
            eh.ErrorReport("账号或密码错误");
        }
    }
}