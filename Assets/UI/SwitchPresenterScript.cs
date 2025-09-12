using UnityEngine;
using Yarn.Unity;

public class SwitchPresenterScript : MonoBehaviour
{
    public LinePresenter dialoguePresenter;
    public LinePresenter monologuePresenter;

    [YarnCommand("auto")]
    public void AutoAdvance(bool autoAdvance)
    {
        //dialoguePresenter.enabled = !autoAdvance;
        dialoguePresenter.autoAdvance = autoAdvance;
        //monologuePresenter.enabled = autoAdvance;
        //monologuePresenter.autoAdvance = autoAdvance;
    }
}
