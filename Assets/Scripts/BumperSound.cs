using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperSound : MonoBehaviour
{
    public AudioSource bumperSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other) {
        bumperSound.Play ();
    }
}
