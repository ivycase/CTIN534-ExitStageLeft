using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class EnableDisableButtonScript : MonoBehaviour
{
    [YarnCommand("enable")]
    public void EnableButton()
    {
        GetComponent<Button>().interactable = true;
    }

    [YarnCommand("disable")]
    public void DisableButton()
    {
        GetComponent<Button>().interactable = false;
    }
}
