using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowPulse : MonoBehaviour
{
    public Light glowLight;
    public float minRange = 4.8f;
    public float maxRange = 8.3f;
    public float rangeSpeed = 1.0f;
    public float intensitySpeed = 0.1f;
    public float minIntensity = 1.0f;
    public float maxIntensity = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        glowLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        glowLight.range = minRange + Mathf.PingPong(Time.time * rangeSpeed, maxRange - minRange);
        glowLight.intensity = minIntensity + Mathf.PingPong(Time.time * intensitySpeed, maxIntensity - minIntensity);
    }
}
