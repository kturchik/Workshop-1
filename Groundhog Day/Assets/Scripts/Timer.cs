using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    // Text box
    private Text timerText;
    // Time counter and maximum time allowed
    private float startTime = 30f;

	// Use this for initialization
	void Start ()
	{
        // Get a reference to the Text component on this gameObject
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
        // Reduce the counter by the amount of time that has passed
        startTime = 30f - Time.time;

        // If time is up end the game
        if (startTime < 0)
        {
            GameOver();
        }

        // Update the text field with the current time
        timerText.text = ("Timer: " + ((int)startTime).ToString());
	}

    void GameOver()
    {
        // If the game is not over
        if (!Score.Instance.gameOver)
        {
            // Return the user's score
            // Debug statements are useful when debugging code
            Debug.Log("game over");
            Debug.Log("score = " + Score.Instance.GetScore());

            // Pause the game
            Time.timeScale = 0;
            // Set the game state to over
            Score.Instance.gameOver = true;
        }
    }
}
