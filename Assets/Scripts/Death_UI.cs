using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death_UI : MonoBehaviour
{
    public AudioSource loseSound;
    public GameObject gameOverCanvas;
    public Text deathText;
    public GameObject restartLoseButton;
    public GameObject exitLoseButton;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
		{
            loseSound.Play ();
            gameOverCanvas.gameObject.SetActive(true);
            deathText.enabled = true;
            restartLoseButton.gameObject.SetActive(true);
            exitLoseButton.gameObject.SetActive(true);
			Destroy(other.gameObject);
		}
    }
}
