using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int health = 3;
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ammo") {
            Destroy(other.collider.gameObject);
            Debug.Log("Hit with Health: " + health);
            health--;
            if (health <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("Destroyed");
            }
        }
    }
}
