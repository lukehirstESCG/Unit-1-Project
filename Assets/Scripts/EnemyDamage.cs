using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    AudioSource audiosource;
    public int damage;
    public PlayerHealth playerHealth;
    public AudioClip Siren;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
            audiosource.PlayOneShot(Siren, 0.7f); // Plays the siren at 70% of it's total volume.
        }
    }
}
