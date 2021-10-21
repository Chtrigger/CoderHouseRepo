using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int PlayerLives = 3;
    private float Speed = 0.3f;
    private bool IsForward = true;

    void Start()
    {
        Debug.Log("En el frame inicial:");
        Debug.Log(transform.position);
        

        
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Por cada frame..");
        Movimiento();
        Debug.Log($"La vida es: {PlayerLives}");
        Damage();
        Debug.Log($"La vida del Player despues del daño es: {PlayerLives}");
        Heal();
        Debug.Log($"La vida del Player luego de una curacion es: {PlayerLives}");

       
        

    }

    void Movimiento()
    {

         Speed = 0.01f;
         
        transform.position += new Vector3(Speed, 0, 0);
        
    }

    void Heal()
    {
        PlayerLives = PlayerLives + 1;
    }

    void Damage()
    {
        PlayerLives = PlayerLives - 1;
    }
}
