using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Page2Check : MonoBehaviour
{
    public InputField result;
    public PageSwitch ps;
    public ErrorHandle eh;

    string correct = @"<!DOCTYPE html>
<html>

<body>
<p>考试题目</p>
<p>1. 这道题选什么？</p>
<p><input type=""checkbox"" name=""A"" value=""A"" />A</p>
<p><input type=""checkbox"" name=""B"" value=""B"" />B</p>
<p><input type=""checkbox"" name=""C"" value=""C"" />C</p>
<p><input type=""checkbox"" name=""D"" value=""D"" />D</p>
<p>2. 你从哪里来？</p>
<p><input type=""checkbox"" name=""A"" value=""A"" />A</p>
<p><input type=""checkbox"" name=""B"" value=""B"" />B</p>
<p><input type=""checkbox"" name=""C"" value=""C"" />C</p>
<p><input type=""checkbox"" name=""D"" value=""D"" />D</p>
<p>3. 你要到哪去？</p>
<p><input type=""checkbox"" name=""A"" value=""A"" />A</p>
<p><input type=""checkbox"" name=""B"" value=""B"" />B</p>
<p><input type=""checkbox"" name=""C"" value=""C"" />C</p>
<p><input type=""checkbox"" name=""D"" value=""D"" />D</p>
<p>4. 怎么通过考试？</p>
<p><input type=""checkbox"" name=""A"" value=""A"" />A</p>
<p><input type=""checkbox"" name=""B"" value=""B"" />B</p>
<p><input type=""checkbox"" name=""C"" value=""C"" />C</p>
<p><input type=""checkbox"" name=""D"" value=""D"" />D</p>

<button type=""button"" onclick=""Check()"">提交</button>
</body>

void Check()
{
	return true;
}

</html>";

    public void Check()
    {
        if(result.text == correct)
        {
            ps.SwitchToGraphic();
        }
        else
        {
            eh.ErrorReport("编译错误");
        }
    }
}
