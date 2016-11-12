using UnityEngine;
using System.Collections;

public class playerJump : MonoBehaviour {
    
    public float jumpHeight;
    public GameObject groundCheck;

    private Rigidbody2D theRigidBody;
    public LayerMask groundMask;

    // Use this for initialization
    void Start()
    {
        theRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool grounded = Physics2D.OverlapCircle(groundCheck.transform.position, 0.1f, groundMask);
        bool inputY = Input.GetButtonDown("Jump");

        if (grounded)
        {
            theRigidBody.isKinematic = true;
        }

        if (grounded && inputY)
        {
            theRigidBody.isKinematic = false;
            theRigidBody.AddForce(new Vector2(0, jumpHeight));
        }
    }
}
