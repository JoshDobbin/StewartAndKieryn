using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public int maxPlatforms = 20;
	public GameObject platform;
	public float horizontalMin = 6.5f;
	public float horizontalMax = 14f;
	public float verticalMin = -6f;
	public float verticalMax = 6f;


	private Vector2 originPostition;

	// Use this for initialization
	void Start () {
		Spawn ();
	
	}
	
	// Update is called once per frame
	void Spawn()
	{
		for (int i = 0; i < maxPlatforms; i++)
		{
			Vector2 randomPosition = originPostition + new Vector2 (Random.Range(horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
			Instantiate(platform, randomPosition, Quaternion.identity);
			originPostition = randomPosition;
		}
	}
}