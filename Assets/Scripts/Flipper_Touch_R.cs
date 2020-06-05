using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper_Touch_R : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 50000f;
    public float flipperDamper = 150f;
    
    HingeJoint hinge;

    public string inputName;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldMousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if (Input.GetAxis(inputName) == 1)
        {
            // if(Input.mousePosition.x > 164f)
            if(worldMousePos.x > .4)
            {
                spring.targetPosition = pressedPosition;
            }
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
