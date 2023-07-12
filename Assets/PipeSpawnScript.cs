using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float HeightOffset = 5;
    
    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
    	if (timer < spawnRate)
    	{
    		timer += Time.deltaTime;
    	}
    	else
    	{
        	spawnPipe();
        	timer = 0;
        }
    }
    
    void spawnPipe()
    {
    	float lowestPoint = transform.position.y - HeightOffset;
    	float highestPoint = transform.position.y + HeightOffset;
    	
        //create a new GameObject "Pipe"
    	Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
    }
}
