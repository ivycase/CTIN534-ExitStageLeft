using UnityEngine;
using Yarn.Unity;

public class SpriteSwapScript : MonoBehaviour
{
    [YarnCommand("change_sprite")]
    public void Swap(string spriteName)
    {
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(string.Format("Sprites/{0}", spriteName));
    }
}
