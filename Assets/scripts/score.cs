using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private Text scoreText;

    // Use this for initialization
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + gameManager.score;
        if (gameManager.score < 0)
        {
            scoreText.color = Color.red;
        }
        else
        {
            scoreText.color = Color.white;
        }
    }
}
