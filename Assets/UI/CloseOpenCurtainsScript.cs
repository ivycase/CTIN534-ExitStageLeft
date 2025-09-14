using TMPro;
using UnityEngine;
using Yarn.Unity;

public class CloseOpenCurtainsScript : MonoBehaviour
{

    public Animator curtainsAnimator;

    [YarnCommand("open")]
    public void OpenCurtains()
    {
        curtainsAnimator.SetTrigger("open");
    }

    [YarnCommand("close")]
    public void CloseCurtains()
    {
        curtainsAnimator.SetTrigger("close");
    }

    [YarnCommand("transition")]
    public void TransCurtains()
    {
        curtainsAnimator.SetTrigger("transition");
    }
}
