using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public LogicManagerScript logicManagerScript;


    // Start is called before the first frame update
    void Start()
    {
        logicManagerScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    private void Update()
    {
       float vertical = Input.GetAxis("Vertical");
       Vector2 position = transform.position;

       position.y = position.y + moveSpeed * vertical * Time.deltaTime;
       transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        Destroy(gameObject);
        logicManagerScript.gameOver();
    }

}