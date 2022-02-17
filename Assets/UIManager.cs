using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text scoreText;

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.text = "Enemies Defeated: " + Enemy.score.ToString();
    }

    public void RetryButton() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
