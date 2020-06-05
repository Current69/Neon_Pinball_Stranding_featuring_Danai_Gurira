using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThudSound : MonoBehaviour
{
    public AudioSource thudSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other) {
        thudSound.PlayOneShot (thudSound.clip, 1f);
    }
}
