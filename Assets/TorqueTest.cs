using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorqueTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddTorque(Vector3.forward*100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
