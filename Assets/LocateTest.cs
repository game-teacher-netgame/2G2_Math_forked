using UnityEngine;
using TMPro;

public class LocateTest : MonoBehaviour
{
    Transform targetTransform;
    [SerializeField]TMPro.TextMeshProUGUI textMeshPro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetTransform = transform.GetChild(0); // Assuming the target is the first child of this GameObject
    }

    // Update is called once per frame
    void Update()
    {
        var selfPosition = $"Self WorldPosition{transform.position.ToString()}";
        var targetPosition = $"Target WorldPosition{targetTransform.position.ToString()}";
        textMeshPro.text = $"Å°{selfPosition}\nÅ°{targetPosition}";
    }
}
