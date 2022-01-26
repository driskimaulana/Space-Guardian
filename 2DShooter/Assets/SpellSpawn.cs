using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSpawn : MonoBehaviour
{
    // spell gameobject
    public GameObject gameObject = null;

    // timer for the next spell
    public float waitingForNextSpawn = 10;
    public float theCountdown = 10;

    // the range of x
    public float xMin;
    public float xMax;

    // the range of y
    public float yMin;
    public float yMax;

    // Update is called once per frame
    void Update()
    {
        // timer to spawn the next spell
        theCountdown -= Time.deltaTime;
        if(theCountdown <= 0)
        {
            SpawnSpell();
            theCountdown = waitingForNextSpawn;
        }
    }

    private void SpawnSpell()
    {
        // random location within the range
        Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));

        // create spell at the random 2D position
        if(gameObject != null)
        {
            Instantiate(gameObject, pos, transform.rotation);
        }

    }
}
