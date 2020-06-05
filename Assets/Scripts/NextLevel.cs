using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public AudioSource levelSound;
    public string scene;
    private bool loadLock;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
		{
            levelSound.Play ();
            Invoke("LoadScene", 1);
		}
    }

    void LoadScene() 
    {
        loadLock = true;
        SceneManager.LoadScene (scene);
    }
}
