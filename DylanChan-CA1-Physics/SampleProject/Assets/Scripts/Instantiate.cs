using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {
    public Transform Sphere;
    int numOfSphere = 10;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < numOfSphere; i++)
            Instantiate(Sphere,
           //Spawn range
           new Vector3(Random.Range(9, -9),
                             Random.Range(6.85f, 6.85f),
                                   Random.Range(9, -9)), Quaternion.identity);
        Sphere.name = "Enemy Sphere";
        

        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
