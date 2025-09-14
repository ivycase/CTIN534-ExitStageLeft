using TMPro;
using UnityEngine;
using Yarn.Unity;

public class CloseOpenCurtainsScript : MonoBehaviour
{

    public Animator curtainsAnimator;
    public AudioSource closeSound;

    [YarnCommand("open")]
    public void OpenCurtains()
    {
        curtainsAnimator.SetTrigger("open");
    }

    [YarnCommand("close")]
    public void CloseCurtains()
    {
        curtainsAnimator.SetTrigger("close");
        closeSound.Play();
    }

    [YarnCommand("transition")]
    public void TransCurtains()
    {
        curtainsAnimator.SetTrigger("transition");
        closeSound.Play();
    }
}
