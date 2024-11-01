using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class breackable : MonoBehaviour
{
    public float time = 2f;
    private float timed = 0f;
    public List<GameObject> pieces;
    public UnityEvent onbreak;
    void Start()
    {
        foreach (var piece in pieces)
        {
            piece.SetActive(false);
        }
    }


    public void Break(){
        timed += Time.deltaTime;
        if (time < timed)
        {
        foreach (var piece in pieces)
        {
            piece.SetActive(true);
            piece.transform.parent = null;
        }
        onbreak.Invoke();
         gameObject.SetActive(false);
        }
        
     }
}
