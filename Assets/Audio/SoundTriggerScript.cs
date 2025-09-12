using UnityEngine;
using Yarn.Unity;

public class SoundTriggerScript : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("Audio source.")]
    private AudioSource audioSource;
    #endregion

    [YarnCommand("play")]
    public void PlaySound(string fileName)
    {
        AudioClip clip = Resources.Load<AudioClip>(string.Format("Clips/{0}", fileName));
        audioSource.clip = clip;
        print(string.Format("Clips/{0}", fileName));
        audioSource.PlayOneShot(clip);
    }
}
