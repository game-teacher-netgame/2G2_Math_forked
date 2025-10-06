using UnityEngine;
using TMPro;
// TEST FOR PULL
public class LocateTest : MonoBehaviour
{
    Transform childTransform;
    [SerializeField] TMPro.TextMeshProUGUI textMeshPro;
    [SerializeField] Transform otherTransform;
    [SerializeField] Transform sphereTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        childTransform = transform.GetChild(0); // Assuming the target is the first child of this GameObject
    }

    // Update is called once per frame
    void Update()
    {
        var selfPosition = $"Self WorldPosition{transform.position.ToString()}";
        var targetPosition = $"Child WorldPosition{childTransform.position.ToString()}";
        var localTargetPosition = $"Child LocalPosition{childTransform.localPosition.ToString()}";
        var otherWorldPosition = $"Other WorldPosition{otherTransform.position.ToString()}";
        var normalizedVector = childTransform.position.normalized;
        var normalizedVectorString = $"Child LocalPosition Normalized: {normalizedVector.ToString()}";
        var testDot = Vector3.Dot(otherTransform.position, normalizedVector);
        var testDotString = $"Dot: {testDot.ToString()}";

        sphereTransform.position = childTransform.right*testDot;
        textMeshPro.text = $"¡{selfPosition}\n"
            + $"¡{targetPosition}\n"
            + $"¡{localTargetPosition}\n"
            + $"¡{normalizedVectorString}\n"
            + $"¡{otherWorldPosition}\n"
            + $"¡{testDotString}";
    }
}
