using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win_UI : MonoBehaviour
{
    public AudioSource winSound;
    public GameObject winCanvas;
    public Text winText;
    public GameObject restartWinButton;
    public GameObject exitWinButton;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
		{
            winSound.Play ();
            winCanvas.gameObject.SetActive(true);
            winText.enabled = true;
            restartWinButton.gameObject.SetActive(true);
            exitWinButton.gameObject.SetActive(true);
			Destroy(other.gameObject);
		}
    }
}
