using TMPro;
using UnityEngine;
using Yarn.Unity;

public class CloseOpenCurtainsScript : MonoBehaviour
{
    public TextMeshPro monologueText;

    [YarnCommand("open")]
    public void OpenCurtains()
    {
        monologueText.enabled = false;
    }

    [YarnCommand("close")]
    public void CloseCurtains()
    {
        monologueText.enabled = true;
    }
}
