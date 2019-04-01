using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static int splats;

    public Text scoreText;
    public Text splatsText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        splatsText.text = "Splats: " + splats.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void addScore()
    {
        score += 100;
        scoreText.text = "Score: " + score.ToString();
    }

    public void addSplats()
    {
        splats++;
        splatsText.text = "Splats: " + splats.ToString();
    }

}
