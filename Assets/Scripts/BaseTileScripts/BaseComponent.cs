using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseComponent : MonoBehaviour
{
    
    public GameObject prev;
    public GameObject next;

    // Start is called before the first frame update
    void Start()
    {
        prev = null;
        next = null;
        //GetComponentInChildren<AudioSource>().Play();
    }

    public void makeConnection(outColliderBehaviour childScript, GameObject prevObj)
    {
        prev = prevObj;
        prevObj.GetComponent<BaseComponent>().next = gameObject;
        Debug.Log("zje[pa");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
