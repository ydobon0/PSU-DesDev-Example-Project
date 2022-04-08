using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Score;
    public float time = 30;
    public Text timeText;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            timeText.text = "Time Left: " + (int)time;
        }
        else
        {
            timeText.text = "Time Left: " + 0;
            endGame();
        }
    }

    public void increaseScore()
    {
        if (Score < 50)
        {
            time += (3 - (Score / 20f));
        }
        else
        {
            time += 0.5f;
        }
        Score++;
        scoreText.text = "Score: " + Score;

    }

    public void endGame()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
