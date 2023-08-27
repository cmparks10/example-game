using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    LogicManagerScript logicManagerScript;

    void Start(){
        logicManagerScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }


    //public GameObject gameObject;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the GameObject you want to destroy
        if (collision.gameObject.CompareTag("AsteroidTag"))
        {
            logicManagerScript.addScore();
            Destroy(gameObject);
            // Destroy the target GameObject
            Destroy(collision.gameObject);
            
            // Destroy the projectile (this GameObject) as well

        }
    }
    
}

