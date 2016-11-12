using UnityEngine;
using System.Collections;

public class playerJump : MonoBehaviour {
    
    public float jumpHeight;
    private Rigidbody2D theRigidBody;


    // Use this for initialization
    void Start()
    {
        theRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float inputY = Input.GetAxis("Vertical");

        theRigidBody.AddForce(new Vector2(0, inputY * jumpHeight));
    }
}
