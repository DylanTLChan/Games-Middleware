using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Reference for Camera Control-- https://www.youtube.com/watch?v=Ta7v27yySKs
public class ThirdPersonCamera : MonoBehaviour {

    
    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 50.0f;


    public Transform LookAt;//Ethan
    public Transform camTransform;//Main Camera

    private Camera cam;

    private float distance = 5.0f;//camera distance
    private float currentX = 0.0f;
    private float currentY = 10.0f;
    //private float sensivityX = 4.0f;
    //private float sensivityY = 1.0f;

   
    // Use this for initialization
    void Start () {

        camTransform = transform;
        cam = Camera.main;

		
	}
	
	// Update is called once per frame
	void Update () {

        //Move with the camera
        currentX += Input.GetAxis("Mouse X");
        currentX += Input.GetAxis("Mouse Y");

        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);

    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = LookAt.position + rotation * dir;
        camTransform.LookAt(LookAt.position);
    }
}
