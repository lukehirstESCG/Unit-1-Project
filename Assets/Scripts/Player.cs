using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D player;
    public float speed;
    public Animator anim;
    bool grounded;
    public GameObject wine;
    HelperScript helper;

    void Start()
        
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        helper = gameObject.AddComponent<HelperScript>();
    }

    void Update()
    {
        if (Input.GetKey("right"))
        {
            player.velocity = new Vector2(5, 0);
            helper.FlipObject(false);
        }
        if (Input.GetKey("left"))
        {
            player.velocity = new Vector2(-5, 0);
            helper.FlipObject(true);
        }

        grounded = true;
    }

}
