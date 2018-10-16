using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public int damage = 1;
    public float speed;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("TOCO");
        if (other.tag == "Player")
        {
            other.GetComponent<Player>().health -= damage;
            Destroy(gameObject);  //elimina el obstacle
        }

    }


}
