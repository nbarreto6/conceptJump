using UnityEngine;
using System.Collections;
using Lean.Touch;

[RequireComponent (typeof (Player))]
public class PlayerInput : MonoBehaviour {

	Player player;
 

    void Start () {
		player = GetComponent<Player> ();
	}

    protected virtual void OnEnable()
    {

        LeanTouch.OnFingerDown += OnFingerDown;
        LeanTouch.OnFingerUp += OnFingerUp;
    }

    protected virtual void OnDisable()
    {
        LeanTouch.OnFingerDown += OnFingerDown;
        LeanTouch.OnFingerUp -= OnFingerUp;
    }

    void OnFingerDown(LeanFinger finger)
    {
        player.OnJumpInputDown();
    }

    void OnFingerUp(LeanFinger finger)
    {
        player.OnJumpInputUp();

       
    }

    void Update () {
		

		if (Input.GetKeyDown (KeyCode.Space)) {
			player.OnJumpInputDown ();
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			player.OnJumpInputUp ();
		}

        else
        {
            Vector2 directionalInput = new Vector2(5, 0);
            player.SetDirectionalInput(directionalInput);
        }
	}


}
