using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Page4Check : MonoBehaviour
{
    public InputField result;
    public PageSwitch ps;
    public ErrorHandle eh;
    public Button btn;
    public PageManager pm;
    public GameCtrl gc;


    string correct = @"<!DOCTYPE html>
<html>

<body>
<p>点击按钮前往Page1</p>
<a href = ""Trap"">
     <button>Page1</button>
</a>
</body>

</html>";

    public void Check()
    {
        if(result.text == correct)
        {
            btn.onClick.AddListener(pm.CloseAll);
            btn.onClick.AddListener(pm.OpenTrap);
            gc.mails[4].SetActive(true);
            ps.SwitchToGraphic();
        }
        else
        {
            eh.ErrorReport("编译错误");
        }
    }
}
