using UnityEngine;
using Yarn.Unity;

public class SpriteSwapScript : MonoBehaviour
{
    [YarnCommand("sprite_swap")]
    public void Swap(string spriteName)
    {
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(string.Format("Sprites/{0}", spriteName));
    }
}
