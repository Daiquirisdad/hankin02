using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public GameManager gm;
    void OnTriggerEnter2D ()
	{
		Debug.Log("YOU MADE IT!");
		Score.CurrentScore += 100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gm.addScore();
    }

}
