using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class base_component : MonoBehaviour
{
    
    public GameObject inPoint;
    public GameObject outPoint;
    // Start is called before the first frame update
    void Start()
    {
        inPoint = null;
        outPoint = null;
        //GetComponentInChildren<AudioSource>().Play();
    }

    void OnCollisionEnter(Collision collision)
    {
        GetComponentInChildren<AudioSource>().Play();
    }

    private void OnTriggerEnter( Collider other )
     {
        inPoint = other.gameObject;
        Debug.Log("che");
        GetComponentInChildren<AudioSource>().Play();
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
