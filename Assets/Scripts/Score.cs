using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int player_score = 0;
    private int high_score = 0;
    public Text player_scoretext;
    public Text high_scoretext;
    private int gameslaunched = 0;
    public Text launch;

    public void Start()
    {
        player_score = 0;

        high_score = PlayerPrefs.GetInt("high_score", high_score);
        high_scoretext.text = high_score.ToString();
        high_scoretext.text = "High Score : " + high_score;
        gameslaunched = 0;
        // Gathers the information for the Game Counter.
        PlayerPrefs.GetInt("gameslaunched", gameslaunched);
        launch.text = "Games Launched : " + gameslaunched;
        launch.text = launch.ToString();

        // Has the game already launched before? If so, add it to the Player Prefs. If no, then make the Player Pref.
        if (PlayerPrefs.HasKey("gameslaunched"))
        {
            gameslaunched = PlayerPrefs.GetInt("gameslaunched");
            gameslaunched += 1;
            PlayerPrefs.SetInt("gameslaunched", gameslaunched);
            launch.text = "Games Launched : " + gameslaunched;
        }
        else
        {
            PlayerPrefs.SetInt("gameslaunched", 1);
            launch.text = "Games Launched : " + 1;

        }
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            player_score += 500;
            PlayerPrefs.SetInt("player_score", player_score);
            player_scoretext.text = "Player Score : " + player_score;
        }
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            player_score -= 500;
            PlayerPrefs.SetInt("player_score", player_score);
            player_scoretext.text = "Player Score : " + player_score;
        }
        if (player_score > high_score)
        {
            high_score = player_score;
            high_scoretext.text = "High Score : " + high_score;
            PlayerPrefs.SetInt("player_score", player_score);
            PlayerPrefs.SetInt("high_score", high_score);
        }

    }
    public void Load()
    {
        // Loads the Scores from a previous session
        high_score = PlayerPrefs.GetInt("high_score");
        high_scoretext.text = high_score.ToString();

    }
}
