using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class YarnOnClickScript : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("Dialogue runner.")]
    private DialogueRunner dialogueRunner;

    [SerializeField]
    [Tooltip("Name of the Yarn node to play.")]
    public string nodeName;
    #endregion

    #region Cached Components
    private Button button;
    #endregion

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
    void OnClick()
    {
        dialogueRunner.StartDialogue(nodeName);
    }
}
