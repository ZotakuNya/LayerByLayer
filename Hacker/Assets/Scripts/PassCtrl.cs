using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassCtrl : MonoBehaviour
{
    public GameCtrl gc;
    public GameObject content;
    public void Disappear()
    {
        content.SetActive(false);
        if (gc.curStage == "Page1")
        {
            gc.ic.ShowMessage("看来这点小问题难不倒你，你应该注意到了，完成任务后能够获得积分。在你摸索系统的时候有发现硬件信息页面吧。你可能觉得我们给你的电脑配置太差，当然，你想要更好的硬件取决于你的表现，在浏览器中输入Shop试试吧，你的积分可以用来购置更好的硬件。你问最后归不归你？在你通过所有考验后，也不是不能考虑。加油吧！");
        }
    }

    public void Show()
    {
        content.SetActive(true);
    }
}
