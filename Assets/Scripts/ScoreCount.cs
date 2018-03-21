using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    [SerializeField]
    public Text scoreDisplay;

    void Update()
    {
        int sco = Bomb.score;
        scoreDisplay.text = "Score "+sco.ToString();

        if (sco >= 5)
        {
            scoreDisplay.text = "You Win!";
        }
    }
}