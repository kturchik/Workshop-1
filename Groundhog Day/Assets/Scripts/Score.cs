using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // Is the game over?
    public bool gameOver = false;
    // Score instance
    public static Score Instance;   // this is created as a public instance so other script's can access this value
    // Score counter
    private float score = 0f;
    // Text box
    private Text scoreText;

	// Use this for initialization
	void Start ()
	{
        // Set the reference of Instance to this (the one the script belongs to) gameObject
        Instance = this;
        // Get a reference to the Text component on this gameObject
        scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
        // Update the text field with the current score
        scoreText.text = "Score: " + score.ToString();
	}

    public void IncrementScore()
    {
        // Add one to the user's score
        score++;
    }

    public float GetScore()
    {
        // Return the user's score
        return score;
    }

    void OnDisable()
    {
        // Disable this gameObject
        Instance = null;
    }
}
