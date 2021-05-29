using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hardware : MonoBehaviour
{
    public GameCtrl gc;
    public Text CPU;
    public float point = 3.0f;
    public Text score;

    public void update1()
    {
        if (gc.point >= 700)
        {
            gc.point -= 700;
            CPU.text = "英特尔（Intel）G5420 奔腾2核4线程";
            point += 0.2f;
            score.text = point.ToString();
            gc.eh.PassReport("升级成功");
        }
        else
        {
            gc.eh.ErrorReport("积分不足");
        }
    }
    
    public void update2()
    {
        
        if (gc.point >= 900)
        {
            gc.point -= 900;
            CPU.text = "英特尔（Intel）i3-10100F 4核8线程";
            point += 0.2f;
            score.text = point.ToString();
            gc.eh.PassReport("升级成功");
        }
        else
        {
            gc.eh.ErrorReport("积分不足");
        }
    }
}
