using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;


public class HandController : MonoBehaviour
{
    public InputActionReference trigger;
    public InputActionReference grip;

    public Hand hand;
    void Start()
    {
        trigger.action.Enable();
        grip.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        hand.SetTrigger(trigger.action.ReadValue<float>());
        hand.SetGrip(grip.action.ReadValue<float>());
    }
}
