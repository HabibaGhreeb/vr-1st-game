using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class trggerzone : MonoBehaviour
{
    public string target;
    public UnityEvent<GameObject> onenter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == target)
        {
            onenter.Invoke(other.gameObject);
        }
    }
}
