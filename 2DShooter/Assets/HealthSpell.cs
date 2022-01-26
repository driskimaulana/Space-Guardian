using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpell : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Heallth ON");
        AddHealth(collision.gameObject);
        this.gameObject.SetActive(false);
    }

    private void AddHealth(GameObject collisionObject)
    {
        /// search health component in the collision object
        Health collisionObjectHealth = collisionObject.GetComponent<Health>();
        HealthBar healthBar = collisionObject.GetComponent<HealthBar>();

        collisionObjectHealth.currentHealth = collisionObjectHealth.maximumHealth;
        if(healthBar != null)
        {
            healthBar.SetHealth(collisionObjectHealth.currentHealth);
        }
    }
}
