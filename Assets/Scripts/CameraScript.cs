using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        transform.position = transform.position + new Vector3(2, 1, -4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
