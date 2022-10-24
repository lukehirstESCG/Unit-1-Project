using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100;
    public float health;
    public Image healthBar;

    public GameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)     
        {
            PlayerDied();
            Destroy(gameObject);
        }

    }
    private void PlayerDied()
    {
        GameManagerScript.instance.GameOver();
    }
}
