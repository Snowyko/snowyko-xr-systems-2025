using UnityEngine;
using UnityEngine.InputSystem;

public class Lightcolor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Light light;
    public Color color;
    public InputActionReference act;

    void Start()
    {
        light = GetComponent<Light>();

        act.action.Enable();
        act.action.performed += (ctx) =>
        {
            light.color = Color.green;
        };
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
