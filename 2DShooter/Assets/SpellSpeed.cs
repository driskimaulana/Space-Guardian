using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSpeed : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Got it\n");
        AddSpeed(collision.gameObject);
        this.gameObject.SetActive(false);
    }

    private void AddSpeed(GameObject collisionObject)
    {
        if(collisionObject != null)
        {
            collisionObject.GetComponent<Controller>().moveSpeed += 5;
        }
    }
}
