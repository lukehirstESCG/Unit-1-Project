using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D player;
    public Animator anim;
    bool grounded;
    HelperScript helper;
    public GameObject fireball;

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
            player.velocity = new Vector3(player.velocity.x, 9, 0);
            grounded = false;

            }
            else
            {
                anim.SetBool("run", player.velocity.magnitude > 0);
                grounded = true;
            }
            int moveDirection = 1;
            if (Input.GetKeyDown("q"))
            {
                // Instantiate the fireball at the position and rotation of the player
                GameObject clone;
                clone = Instantiate(fireball, transform.position, transform.rotation);

                // get the rigidbody component
                Rigidbody2D rb = clone.GetComponent<Rigidbody2D>();

                // set the velocity
                rb.velocity = new Vector3(15 * moveDirection, 0, 0);

                //set the position close to the player
                rb.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z + 1);
                Object.Destroy(clone.gameObject, 4.0f);
            }    }
    }
