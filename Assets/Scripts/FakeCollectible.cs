using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeCollectible : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("You notice a weird aura around this coin, upon further inspection, the coin is found to be an evil amulet, that curses anyone who tries to take it. You have been dealt 30 HP loss from the amulet. Be careful though, more than 3 will kill you!");
            playerHealth.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
