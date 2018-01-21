using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    private List<GameObject> coyotes;
    public GameObject coyotePrefab;
    public int maxSpawn;
    public int spawnDelay;

    public int deadCoyotes;

    private float timer;
    private float startTime;

    public GameObject[] spawners;

	// Use this for initialization
	void Start () {
        startTime =  0;
        coyotes = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        int seconds = System.Convert.ToInt32(timer % 60);
        if (timer - startTime >= spawnDelay && coyotes.Count<maxSpawn)
        {
            int tmp = Random.Range(0, spawners.Length);
            coyotes.Add(Instantiate(coyotePrefab, new Vector3(spawners[tmp].transform.position.x, spawners[tmp].transform.position.y, 0.01f*coyotes.Count), spawners[tmp].transform.rotation));
            startTime = timer;
        }
	}

    public void removeCoyote(GameObject coyote)
    {
        coyotes.Remove(coyote);
        deadCoyotes++;
    }
}
