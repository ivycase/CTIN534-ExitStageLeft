using TMPro;
using UnityEngine;
using Yarn.Unity;

public class CloseOpenCurtainsScript : MonoBehaviour
{
    public GameObject dialogueText;
    public GameObject monologueText;

    [YarnCommand("open")]
    public void OpenCurtains()
    {
        dialogueText.GetComponent<TextMeshProUGUI>().text = "";
        monologueText.GetComponent<CanvasRenderer>().SetAlpha(0);
        dialogueText.GetComponent<CanvasRenderer>().SetAlpha(1);
    }

    [YarnCommand("close")]
    public void CloseCurtains()
    {
        monologueText.GetComponent<TextMeshProUGUI>().text = "";
        monologueText.GetComponent<CanvasRenderer>().SetAlpha(1);
        dialogueText.GetComponent<CanvasRenderer>().SetAlpha(0);
    }
}
