using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        if (GameManagerScript.instance == null) instance = this;
        else Destroy(gameObject);
    }
    public void GameOver()
    {
        UIManager _ui = GetComponent<UIManager>();
            if (_ui != null)
        {
            _ui.ToggleDeathPanel();
        }
    }
    public void ApplicationQuit()
    {
        print("Quit");
        Application.Quit();
    }
}
