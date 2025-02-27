using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.Events;

public class Points : MonoBehaviour
{
    public UnityEvent scored;

    public void Start()
    {
        scored.AddListener(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().upScore);
        scored.AddListener(GameObject.FindGameObjectWithTag("Scores").GetComponent<ScoreCounter>().UpdateScore);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            scored.Invoke();
        }
    }

    public void TestMethod()
    {
        Debug.Log("Scored");
    }
}
