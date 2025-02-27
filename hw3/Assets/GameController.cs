using UnityEngine;

public class GameController : MonoBehaviour
{
    public int score { get; private set; }

    public Material Ball;

    public Color gold;

    public Color norm;


    public void Start()
    {
        score = 0;
        Ball.color = norm;
        
    }

    public void Update()
    {
        if (score == 10)
        {
            Ball.color = gold;
        }
    }

    public void upScore()
    {
        score++;
    }
}
