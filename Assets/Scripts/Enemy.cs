using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject bulletPrefab;
    float timeToShoot = 1;
    
	
    // Use this for initialization
	void Start () {
	    	
	}
	
	// Update is called once per frame
	void Update () {
        timeToShoot -= Time.deltaTime;
        if (timeToShoot < 0)
        {
            Instantiate(bulletPrefab, transform.position + new Vector3(4f, 0, 0), transform.rotation);
            timeToShoot = 2;
        }

    }
}
