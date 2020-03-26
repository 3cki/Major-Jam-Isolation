using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    public GameObject lightswitch;

    void Start()
    {
        lightswitch.transform.localEulerAngles = new Vector3(35, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
