using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atma : MonoBehaviour
{
    
    Rigidbody top;
    public GameObject go;
    public static int a;
    bool sa;
    // Start is called before the first frame update
    void Start()
    {
       top = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0) && !sa)
        {
            //top.transform.position = new Vector3(top.transform.position.x, top.transform.position.y + a, top.transform.position.z + a);
            //a += 1;
            
            Instantiate(go);
            //sa = true;
        }
    }
}
