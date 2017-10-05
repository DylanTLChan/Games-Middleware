using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //reference: https://unity3d.com/learn/tutorials/temas/multiplayer-networking/shooting-single-player

    public GameObject SpherePrefab;
    public Transform SphereSpawn;
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //setting key input to chatacter

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 100.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireSpheres();
        }
	}

    private void FireSpheres()
    {

        var bullet = (GameObject)Instantiate(
            SpherePrefab,
            SphereSpawn.position,
            SphereSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<SpherePhysicsCode>().velocity = bullet.transform.forward * 6;

    }

}
