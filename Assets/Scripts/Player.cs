using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D player;
    public Animator anim;
    bool grounded;
    HelperScript helper;

    void Start()
        
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        helper = gameObject.AddComponent<HelperScript>();
    }

    void Update()
    {
        helper.DoRayCollisionCheck();
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
        // Tells the player to jump if on the ground
        if (Input.GetKeyDown("space") && grounded)
        {
            grounded = false;
            player.velocity = new Vector3(player.velocity.x, 10, 0);
        }
        else
        {
            anim.SetBool("run", player.velocity.magnitude > 0);
            grounded = true;
        }
    }

}
