using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controller2D))]
public class Bullet : MonoBehaviour {

    Controller2D controller;

    // Use this for initialization
    void Start () {
        controller = GetComponent<Controller2D>();
    }
	
	// Update is called once per frame
	void Update () {
        controller.Move(new Vector2(10,0) * Time.deltaTime, new Vector2(1,0));
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
            Destroy(gameObject);
    }
}
