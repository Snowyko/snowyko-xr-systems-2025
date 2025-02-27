using UnityEngine;

public class MoveGoal : MonoBehaviour
{
    public float speed = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x <= 10)
            transform.position = new Vector3(transform.localPosition.x + speed, transform.localPosition.y, transform.localPosition.z);
        if (transform.localPosition.x > 10)
            transform.position = new Vector3(0 + speed, transform.localPosition.y, transform.localPosition.z);
    }
}
