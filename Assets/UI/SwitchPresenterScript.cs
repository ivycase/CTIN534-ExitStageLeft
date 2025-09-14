using TMPro;
using UnityEngine;
using Yarn.Unity;

public class SwitchPresenterScript : MonoBehaviour
{
    public LinePresenter dialoguePresenter;
    public LinePresenter monologuePresenter;

    public TMPro.TMP_Text dialogueText;
    public TMPro.TMP_Text monologueText;

    private bool isMonologue = false;

    [YarnCommand("auto")]
    public void AutoAdvance(bool autoAdvance)
    {
        //dialoguePresenter.enabled = !autoAdvance;
        dialoguePresenter.autoAdvance = autoAdvance;
        //monologuePresenter.enabled = autoAdvance;
        //monologuePresenter.autoAdvance = autoAdvance;
    }

    [YarnCommand("swap_presenter")]
    public void SwapPresenter()
    {
        isMonologue = !isMonologue;

        if (isMonologue)
        {
            monologueText.text = "";
            monologueText.GetComponent<CanvasRenderer>().SetAlpha(1);
            dialogueText.GetComponent<CanvasRenderer>().SetAlpha(0);
            dialoguePresenter.useTypewriterEffect = false;
            dialoguePresenter.lineText = monologueText;
        }
        else
        {
            dialogueText.text = "";
            monologueText.GetComponent<CanvasRenderer>().SetAlpha(0);
            dialogueText.GetComponent<CanvasRenderer>().SetAlpha(1);
            dialoguePresenter.useTypewriterEffect = true;
            dialoguePresenter.lineText = dialogueText;
        }
    }
}
