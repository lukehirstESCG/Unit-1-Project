using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip BackgroundMusic;

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
        audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
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
        }
        void Audio()
        {
            audiosource.PlayOneShot(BackgroundMusic, 0.8f); //plays the background music at 80% of the normal value
        }
    }
    }
