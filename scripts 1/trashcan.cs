using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashcan : MonoBehaviour
{
    private void Start()
    {
        GetComponent<trggerzone>().onenter.AddListener(insidetrash);
    }
    public void insidetrash(GameObject go)
    {
       go.SetActive(false);
    }
}
