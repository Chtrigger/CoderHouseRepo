using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("En el frame inicial:");
        Debug.Log(transform.position);
        transform.localScale = new Vector3(3, 3, 3);

        
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Por cada frame..");
        transform.position += new Vector3(1,0,0);
    }
}
