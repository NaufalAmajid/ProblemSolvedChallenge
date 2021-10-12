using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        scoreText.text = "Score : " + score;
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D box)
    {
        if (box.tag =="spawnObject")
        {
            score += 1;
            Destroy(box.gameObject);
            scoreText.text = "Score : " + score;

        }    


    }

}
