using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    TextMesh scoreText;

    GameController gameController;

    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        scoreText = GetComponent<TextMesh>();
    }

    public void UpdateScore()
    {
        scoreText.text = (gameController.score / 2).ToString();
    }
}
