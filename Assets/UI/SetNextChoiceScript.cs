using UnityEngine;
using Yarn.Unity;

public class SetNextChoiceScript : MonoBehaviour
{
    [YarnCommand("next_choice")]
    public void SetNext(string nodeName)
    {
        GetComponent<YarnOnClickScript>().nodeName = nodeName;
    }
}
