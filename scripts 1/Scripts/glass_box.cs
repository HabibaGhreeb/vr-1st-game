using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class glass_box : MonoBehaviour
{
    [SerializeField] Key myKey;

  public string KeyID;

    public UnityEvent OnCorrectEvent;
    public UnityEvent OnWrongEvent;

    void Start()
    {
        KeyID = myKey.GetKeyID();
    }

    public void CheckOpenbox()
    {
        bool HaveKey = false;

        for (int i = 0; i < KeyManager.instance.KeysIDList.Count; i++)
        {
            if (KeyManager.instance.KeysIDList[i] == KeyID)
            {
                HaveKey = true;
                break;
            }
        }

        if (HaveKey)
            OnCorrectEvent.Invoke();
        else
            OnWrongEvent.Invoke();
    }
}
