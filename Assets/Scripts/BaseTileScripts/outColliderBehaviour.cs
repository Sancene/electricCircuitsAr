using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outColliderBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter( Collider other )
    {
        if(other.tag == "in") {
            Debug.Log("out");
            gameObject.GetComponent<AudioSource>().Play();
            transform.parent.GetComponent<BaseComponent>().makeConnection(this, other.gameObject.transform.parent.gameObject);
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
