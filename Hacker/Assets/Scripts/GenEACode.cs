using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenEACode : MonoBehaviour
{
    public string currentLevel;
    public ErrorHandle eh;
    public InputField p3;

    public void GenCode()
    {
        if(currentLevel == "Page3")
        {
            p3.text = @"<!DOCTYPE html>
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

<form action=""action_page.php"" method=""POST"">
 .
ExhaustiveAttack(""ABCD"",form);
 .
</form>

<button type=""submit"">提交</button>
</body>

</html>";
            eh.PassReport("已生成穷举代码");
        }
        else
        {
            eh.ErrorReport("无可穷举攻击目标");
        }
    }
}
