using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{ 
    public float maxHealth = 50f;
    public float speed = 100f; // Speed of the object's movement
    public Vector3 direction = Vector3.forward; // Direction of movem
    // Update is called once per frame
    public void TakeDamage(float amount)
    {
        transform.Translate(direction * speed * Time.deltaTime);
        maxHealth -= amount; 
        if(maxHealth < 0f)
        {
            Die();  
        }
    }
    public void Die()
    {
        Destroy(gameObject); 
    }
}
