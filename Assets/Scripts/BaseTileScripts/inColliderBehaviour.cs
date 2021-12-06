using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inColliderBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter( Collider other )
    {
        if(other.tag == "out") {
            Debug.Log("in");
            gameObject.GetComponent<AudioSource>().Play();
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
