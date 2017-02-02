using UnityEngine;
using System.Collections;

public class Mole : MonoBehaviour
{
    // On-Hit Effect
    private SpriteRenderer renderer;
    private Animator anim;


    private void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        renderer = GetComponent<SpriteRenderer>();
        // get a reference to the Animator component on this gameObject
        anim = GetComponent<Animator>();

    }

    void OnMouseDown()
    {
        // Load On-Hit effect
        renderer.material.SetColor("_Color", Color.red);
        anim.SetBool("isHit", true);
    }
}
