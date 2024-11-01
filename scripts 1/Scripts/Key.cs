using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public string keyid = "";

    public string GetKeyID()
    {
        int randomCode = Random.Range(1000000, 9999999);
        keyid = gameObject.name + "_" + randomCode;
        return keyid; 
    }

    public void CollectKey()
    {
        KeyManager.instance.AddKey(keyid);
        Destroy(gameObject);
    }
}
