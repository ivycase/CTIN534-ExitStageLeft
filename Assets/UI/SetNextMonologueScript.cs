using UnityEngine;
using Yarn.Unity;

public class SetNextMonologueScript : MonoBehaviour
{
    [YarnCommand("next_monologue")]
    public void SetNext(string nodeName)
    {
        GetComponent<YarnOnClickScript>().nodeName = nodeName;
    }
}
