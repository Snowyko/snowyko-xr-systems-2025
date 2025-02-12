using UnityEngine;

public class Angles : MonoBehaviour
{

    Camera myCam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        myCam.transform.localRotation = Camera.main.transform.localRotation;
    }
}
