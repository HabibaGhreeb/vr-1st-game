using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class spaceoutside : MonoBehaviour
{

    public XRLever lever;
    public XRKnob knob;

    public float forwardSpeed;
    public float sideSpeed;

    private bool wason;
    void Update()
    {
        float forwardVelocity = forwardSpeed * (lever.value ? 1 : 0);
        float sideVelocity = sideSpeed * Mathf.Lerp(-1, 1, knob.value);

        Vector3 velocity = new Vector3(sideVelocity, 0, forwardVelocity);
        transform.position += velocity * Time.deltaTime;
        if (lever.value!=wason) {
            if (lever.value)
             {
            AudioManager.instance.Play("engine");
             }
            else
            {
            AudioManager.instance.Stop("engine");
            } 
        }
        
        wason=lever.value;
    }

}
