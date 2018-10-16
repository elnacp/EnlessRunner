using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    private Vector3 targetPosition;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;


    public int health = 3;

	void Update () {

        if( health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) { 
            targetPosition = new Vector3(transform.position.x, transform.position.y + Yincrement);
            
        }else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) { 
            targetPosition = new Vector3(transform.position.x, transform.position.y - Yincrement);
            
        }

    
	}
}
