using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class metior : MonoBehaviour
{
    public ParticleSystem particle; 
    public LayerMask layermask;
    public Transform shootsource;
    public float distance = 10;
    private bool rayactive=false;
    void Start()
    {
        XRGrabInteractable gi = GetComponent<XRGrabInteractable>();
        gi.activated.AddListener(x=>startshoot());
        gi.activated.AddListener(x=>stopshoot());

    }
    public void startshoot()
    {
        AudioManager.instance.Play("pistl");
        particle.Play();
        rayactive = true;
    }
    public void stopshoot()
    {
        AudioManager.instance.Stop("pistl");
        rayactive = false;
        particle.Stop(true,ParticleSystemStopBehavior.StopEmittingAndClear);
    }
    private void Update()
    {if (rayactive)
        RaycastCommand();
    }
    void RaycastCommand()
    {
        RaycastHit hit;
       bool hashit= Physics.Raycast(shootsource.position,shootsource.forward,out hit,distance,layermask);
       if (hashit) {

            hit.transform.gameObject.SendMessage("Break",SendMessageOptions.DontRequireReceiver);
        }
    
    
    }
}
