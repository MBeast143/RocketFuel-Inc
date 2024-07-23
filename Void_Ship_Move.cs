using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void_Ship_Move : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
   // public Transform transforms;
    public float maxSpeed = 20;
    public float thrust = 5;
   
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.KeypadEnter) == true)//right
        {
            MyRigidBody.velocity =  Vector2.zero ;
            MyRigidBody.rotation = 0;
            MyRigidBody.position = Vector3.zero  ;
        }
        

    }
    void FixedUpdate()
    {
        

        if (Input.GetKey(KeyCode.UpArrow))
        {
            MyRigidBody.AddForce(transform.up * thrust,ForceMode2D.Force );
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if ((MyRigidBody.velocity.x > 2f) == true || (MyRigidBody.velocity.y > 2f))
            {
                MyRigidBody.drag = 1f;
                
            }
            else
            {
                MyRigidBody.AddForce(transform.up * (-thrust/2), ForceMode2D.Force);
                MyRigidBody.drag = 0.2f;
            }
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MyRigidBody.rotation = MyRigidBody.rotation + 90 * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MyRigidBody.rotation = MyRigidBody.rotation - 90 * Time.fixedDeltaTime;
        }
       // MyRigidBody.rotation = rotations;
     
        if (MyRigidBody.velocity.magnitude > maxSpeed)
        {
            MyRigidBody.velocity = MyRigidBody.velocity.normalized * maxSpeed;
        }
    }
}
