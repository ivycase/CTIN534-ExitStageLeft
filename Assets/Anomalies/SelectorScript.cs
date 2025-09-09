using System.Collections.Generic;
using UnityEngine;

public class SelectorScript : MonoBehaviour
{

    #region Editor Variables
    [SerializeField]
    [Tooltip("Whether the Selector is enabled.")]
    private bool isActive = false;

    [SerializeField]
    [Tooltip("The size of the Selector area.")]
    private float radius = 10f;

    [SerializeField]
    [Tooltip("The sprite that visualizes the Selector area.")]
    private SpriteRenderer circleSprite;
    #endregion

    #region Private Variables
    private bool hasInitialized = false;
    #endregion

    void Update()
    {
        if (!isActive) return;
        else if (!hasInitialized) Initialize();

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        circleSprite.transform.position = new(mousePosition.x, mousePosition.y);

        if (Input.GetMouseButtonDown(0))
        {
            Collider2D[] results = Physics2D.OverlapCircleAll(mousePosition, radius);
            if (results.Length > 0) print("anomaly!");
            else print("no anomaly...");
        }

    }

    void Initialize()
    {
        circleSprite.transform.localScale = Vector3.one * radius * 2f;
        circleSprite.enabled = true;
        hasInitialized = true;
    }
}
