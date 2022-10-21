using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int health;
    public Image HealthBar;

    public GameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)     
        {
            PlayerDied();
            GameObject.Destroy(gameObject);
        }

    }
    private void PlayerDied()
    {
        GameManagerScript.instance.GameOver();
    }
}
