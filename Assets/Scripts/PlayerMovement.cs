using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private float speed;
    private Rigidbody2D player;

    private void Awake()
    {
        player = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        player.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, player.velocity.y);

        if(Input.GetKey(KeyCode.Space))
    }
}
