using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle : MonoBehaviour
{
    public GameObject gameOverSetup;
    public GameObject defaultScore;
    public Text finalScore;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            gameOverSetup.SetActive(true);
            defaultScore.SetActive(false);
            finalScore.text = Enemy.score.ToString();
            Time.timeScale = 0;
        }
    }
}
