using UnityEngine;
using UnityEngine.Rendering.Universal;
using Yarn.Unity;

public class LightColorScript : MonoBehaviour
{
    private bool isDefault = true;

    [YarnCommand("swap_color")]
    public void LightColor()
    {
        isDefault = !isDefault;

        if (isDefault)
        {
            GetComponent<Light2D>().color = new Color(1.0f, 1.0f, 1.0f);
        }
        else
        {
            GetComponent<Light2D>().color = new Color(0.0f, 0.82352941176f, 1.0f);
        }
    }
}
