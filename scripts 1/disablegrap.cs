using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class disablegrap : MonoBehaviour
{
    public GameObject left;
    public GameObject right;    
    void Start()
    {
      XRGrabInteractable interactable=GetComponent<XRGrabInteractable>();
        interactable.selectEntered.AddListener(hidehand);
        interactable.selectExited.AddListener(showhand);
    }

  public void hidehand(SelectEnterEventArgs args) 
    {
        if (args.interactorObject.transform.tag =="left")
      
            left.SetActive(false);
    
        else if(args.interactorObject.transform.tag =="right")
            right.SetActive(false);

    }
    public void showhand(SelectExitEventArgs args)
    {
        if (args.interactorObject.transform.tag == "left")

            left.SetActive(true);

        else if (args.interactorObject.transform.tag == "right")
            right.SetActive(true);

    }
}
