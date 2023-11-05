using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManger : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 34;
    public int numberOfTiles = 5;
    private List<GameObject> activeTiles = new List<GameObject>();
    public Transform playerTransform;
    void Start()
    
    {
        for(int i = 0; i < numberOfTiles; i++)
        {
            if(i ==0)
            {
                SpawnTile(0);
            }
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z -45 > zSpawn -(numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTiles();
            
        }
        
    }
    public void SpawnTile(int tileIndex)
    {
        GameObject go = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLength;

    }
    private void DeleteTiles()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);

    }
}
