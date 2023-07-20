using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atma1 : MonoBehaviour
{
    bool a = true;
    Rigidbody top;
    // Start is called before the first frame update
    void Start()
    {
        top = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (a)
        {
            top.GetComponent<Rigidbody>().AddForce(transform.forward * 100);
            a = false;
        }
        
    }
}
