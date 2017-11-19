using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


//Reference: https://www.youtube.com/watch?v=JlKf0h0K5PU
public class SetupLocalPlayer : NetworkBehaviour 
{

 
	

	// Use this for initialization
	void Start () {
        //if you are the local player turn on the EnemyMovement script, otherwise other instance in the scene dont enable it.
        if (isLocalPlayer)
            GetComponent<EnemyMovement>().enabled = true;
        else
            GetComponent<EnemyMovement>().enabled = false;

	}
}
