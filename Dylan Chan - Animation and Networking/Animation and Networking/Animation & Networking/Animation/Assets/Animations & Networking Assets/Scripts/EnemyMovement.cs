using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;



//Reference: https://www.youtube.com/watch?v=YgaLKrSApWM
public class EnemyMovement : NetworkBehaviour
{

    // Use this for initialization

    private Animator _animator;
    public Transform ball;
    public GameObject baller;
   
    

    void Start()
    {
        _animator = GetComponent<Animator>();
       


    }

    // Update is called once per frame
    void Update()
    {

        if (_animator == null) return;

        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        Move(x, y);

        //Wave
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("Wave", true);

        }

        else
        {
            _animator.SetBool("Wave", false);
        }

        //Throw
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _animator.SetBool("Throw", true);
            Transform newBall = Instantiate(ball, _animator.GetBoneTransform(HumanBodyBones.RightHand).position, Quaternion.identity);
            BallControl theBall = newBall.GetComponent<BallControl>();
            theBall.inform(_animator, _animator.GetBoneTransform(HumanBodyBones.RightHand));
            //newBall = baller.transform;
            //ClientScene.RegisterPrefab(baller);
            //NetworkServer.Spawn(baller);
            
            
         
            

           


        }

        else
        {
            _animator.SetBool("Throw", false);
        }

        //Catch
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _animator.SetBool("Catch", true);

        }

        else
        {
            _animator.SetBool("Catch", false);
        }

        //Jump
        if (Input.GetKeyDown(KeyCode.X))
        {
            _animator.SetBool("Jump", true);

        }

        else
        {
            _animator.SetBool("Jump", false);
        }

        //For Waving and Walking (Waving Avatar Mask)
        if(Input.GetKeyDown(KeyCode.M))
        {
            _animator.SetTrigger("Waving");
        }
    }

    private void Move(float x, float y)
    {
        _animator.SetFloat("VelX", x);
        _animator.SetFloat("VelY", y);

    }
}
