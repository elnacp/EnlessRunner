using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Vector2 targetPosition;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
   	
	void Update () {

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed);
    
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) { 
            targetPosition = new Vector2(transform.position.x, transform.position.y + Yincrement);
            
        }else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) { 
            targetPosition = new Vector2(transform.position.x, transform.position.y - Yincrement);
            
        }

    
	}
}
