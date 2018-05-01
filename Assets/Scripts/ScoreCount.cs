using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    [SerializeField]
    public Text scoreDisplay;

    void Update()
    {
        int sco = Bomb.score+Bomb_disarmed.score;
        scoreDisplay.text = "Score "+sco.ToString();

        if (sco >= 4)
        {
            scoreDisplay.text = "You Win!";
        }
    }
}