using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour
{
	public Object zombie; // Zombie prefabs to instantiate
	public float spawninterval; // delay between spawns
	public float nextspawn; // when next spawn is due

	// Use this for initialization
	void Start ()
	{
		nextspawn = Time.time+spawninterval; // set initial next spawn time
	}

	// Update is called once per frame
	void Update ()
	{
		if(Time.time > nextspawn)
		{
			nextspawn = Time.time+spawninterval; // set next spawn time
			SpawnZombie(); // call spawn method
		}
	}

	void SpawnZombie()
	{
        var x = Random.Range(100, 650);
        var z = Random.Range(100, 650);
        Instantiate(zombie, new Vector3(x, 2, z), transform.rotation); // create zombie
	}
}