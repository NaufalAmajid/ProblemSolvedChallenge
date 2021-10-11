using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerControl : MonoBehaviour
{
    public int numberToSpawn;

    public List<GameObject> spawnPool;

    public GameObject quad;

    void Start()
    {
        spawnObjects();
    }

    public void spawnObjects(){

        destroyObject();

        int randomItem = 0;

        GameObject toSpawn;

        MeshCollider collider = quad.GetComponent<MeshCollider>();

        float screenx, screeny;
        Vector2 position;

        for(int i = 0; i < numberToSpawn; i++){

            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenx = Random.Range(collider.bounds.min.x, collider.bounds.max.x);
            screeny = Random.Range(collider.bounds.min.y, collider.bounds.max.y);
            position = new Vector2(screenx, screeny);

            Instantiate(toSpawn, position, toSpawn.transform.rotation);
        }

    }

    public void destroyObject(){

        foreach (GameObject o in GameObject.FindGameObjectsWithTag("spawnObject"))
        {
            Debug.Log("Destroy");
        }

    }

}
