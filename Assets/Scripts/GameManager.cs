using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public List<GameObject> PopulatableObjects;

	// Use this for initialization
	void Start () {
        populate();
    }

    void populate() {
        foreach (GameObject obj in PopulatableObjects)
        {
            int randX = (int)Random.Range(-100f, 250f);
            int randY = (int)Random.Range(-20f, 20f);
            Instantiate(obj, new Vector3(Random.Range(-100f, 250f), Random.Range(-20, 20), 0), obj.transform.rotation);
            Instantiate(obj, new Vector3(Random.Range(-100f, 250f), Random.Range(-20, 20), 0), obj.transform.rotation);
            Instantiate(obj, new Vector3(Random.Range(-100f, 250f), Random.Range(-20, 20), 0), obj.transform.rotation);
            Instantiate(obj, new Vector3(Random.Range(-100f, 250f), Random.Range(-20, 20), 0), obj.transform.rotation);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
