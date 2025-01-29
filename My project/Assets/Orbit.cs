using UnityEngine;

public class Orbit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float degPerSec = 6.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, degPerSec * Time.deltaTime, 0);
    }
}
