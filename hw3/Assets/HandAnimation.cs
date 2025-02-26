using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    [SerializeField] private InputActionReference gripRef;
    [SerializeField] private InputActionReference triggerRef;
    [SerializeField] private Animator handAnimator;
    // Update is called once per frame
    void Update()
    {
        float gripValue = gripRef.action.ReadValue<float>();
        float triggerValue = triggerRef.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
        handAnimator.SetFloat("Trigger", triggerValue);
    }
}
