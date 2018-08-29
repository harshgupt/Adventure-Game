using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit : MonoBehaviour {

    public static int score = 0;
    public Text scoreText;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Blade")
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
