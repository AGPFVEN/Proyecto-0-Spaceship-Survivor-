using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    Text score_Text;
    GameObject player_Gameobject;
    StarshipController starship_Script;
    int score_int_UI;

    void Awake()
    {
        score_Text = GetComponent<Text>();
        player_Gameobject = GameObject.FindGameObjectWithTag("Player");
        starship_Script = player_Gameobject.GetComponent<StarshipController>();
    }
    void Update()
    {
        score_Text.text = "Score: " + starship_Script.score_Starship.ToString();
    }
}
