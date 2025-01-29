using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool tp;
    public InputActionReference act;
    public float dist = 100;

    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        act.action.Enable();
        act.action.performed += (ctx) =>
        {
            tp = !tp;
            Vector3 pos = gameObject.transform.position;
            if (tp)
            {
                gameObject.transform.position = new Vector3(pos.x + dist, pos.y, pos.z);
            } 
            else
            {
                gameObject.transform.position = new Vector3(pos.x - dist, pos.y, pos.z);
            }
        };
    }
}
