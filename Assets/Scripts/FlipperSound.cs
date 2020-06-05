using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperSound : MonoBehaviour
{
    public AudioSource flipperSound;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) || (Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.D)))
        {
            flipperSound.PlayOneShot (flipperSound.clip, 0.75f);
        }
    }
}
