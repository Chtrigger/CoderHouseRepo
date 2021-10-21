using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedEnemy = 20.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= 0)
        {
            
            MoveEnemyBack();

        }
        else
        if(transform.position.x >=5)
        {
            MoveEnemyForward();
        }
        
    }
    private void MoveEnemyForward()
    {  
            transform.Translate(speedEnemy * Time.deltaTime * Vector3.forward);
    }
    private void MoveEnemyBack()
    {
        transform.Translate(speedEnemy * Time.deltaTime * Vector3.back);
    }


}   
