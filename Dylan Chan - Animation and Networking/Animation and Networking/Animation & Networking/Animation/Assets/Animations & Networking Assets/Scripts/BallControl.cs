using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour 
{

    Transform theHand;
    Animator theAnimation;
    public Rigidbody rb;
    // Use this for initialization
    void Start () {
       rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (theAnimation.IsInTransition(0)) print("Done"); else print("Doing");

        if (stillBeingThrown())
            transform.position = theHand.position;
        else
            ;

        

    }

    private bool stillBeingThrown()
    {
        return theAnimation.GetAnimatorTransitionInfo(0).IsName("Throw");

    }
        

    internal void inform(Animator _animator, Transform transform)
    {
        theHand = transform;
        theAnimation = _animator;
    }
    void FixedUpdate()
    {
        //rb.velocity = new Vector3(10, 0, 0);
     
    }
}
