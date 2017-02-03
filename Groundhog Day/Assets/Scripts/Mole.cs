using UnityEngine;
using System.Collections;

public class Mole : MonoBehaviour
{
    // On-hit effect
    private SpriteRenderer renderer;
    // Animation controller
    private Animator anim;


    private void Awake()
    {
        // Get a reference to the SpriteRenderer component on this gameObject
        renderer = GetComponent<SpriteRenderer>();
        // Get a reference to the Animator component on this gameObject
        anim = GetComponent<Animator>();

    }

    void OnMouseDown()
    {
        // If the game is not over
        if (!Score.Instance.gameOver)
        {
            // Load on-hit effect
            renderer.material.SetColor("_Color", Color.red);
            anim.SetBool("isHit", true);
            // Add one to the user's score
            Score.Instance.IncrementScore();
        }
    }
}
