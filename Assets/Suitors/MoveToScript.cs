using DG.Tweening;
using UnityEngine;

public class MoveToScript : MonoBehaviour
{

    #region Editor Variables
    [SerializeField]
    [Tooltip("The animation's transition duration.")]
    private float moveDuration = 1.0f;

    [SerializeField]
    [Tooltip("The target position for movement.")]
    private Vector2 targetPosition = new Vector2(0, 0);
    #endregion


    void Start()
    {
        transform.DOMove(targetPosition, moveDuration).SetEase(Ease.InBack);
    }
}
