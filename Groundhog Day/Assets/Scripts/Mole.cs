using UnityEngine;
using System.Collections;

public class Mole : MonoBehaviour {
    // On-Hit Effect
    public GameObject onHit;
    private SpriteRenderer renderer;
    private Animator anim;


    private void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        renderer = GetComponent<SpriteRenderer>();
        // animation.Blend("animation",target distance(i.e. 5.0=50% of animation),fadelength(i.e. speed of the aniamtion to blend in));
        anim = GetComponent<Animator>();
        
    }

    void OnMouseDown() {

        // Load On-Hit effect
        //SpriteRenderer.color = new Color(0f, 0f, 0f, 1f);
        renderer.material.SetColor("_Color", Color.red);
        anim.SetBool("isHit", true);
        // Destroy it after a while
        //Destroy(g, 0.2f);
    }
}
