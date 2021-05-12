using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Page1Check : MonoBehaviour
{
    public InputField result;
    public PageSwitch ps;
    public Button lockBtn;
    public ErrorHandle eh;

    string correct = @"<!DOCTYPE html>
<html>

<body>
<p>尝试让按钮可被点击</p>
<button type=""button"">通关！</button>
</body>

</html>";

    public void Check()
    {
        if(result.text == correct)
        {
            lockBtn.interactable = true;
            ps.SwitchToGraphic();
        }
        else
        {
            eh.ErrorReport("编译错误");
        }
    }
}
