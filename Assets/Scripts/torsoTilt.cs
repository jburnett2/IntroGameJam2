using UnityEngine;
using System.Collections;

public class torsoTilt : MonoBehaviour {

    public float tiltForce;
    private Rigidbody2D theRigidBody;

    // Use this for initialization
    void Start () {
        theRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float inputX = Input.GetAxis("Horizontal");

        theRigidBody.AddForce(new Vector2(inputX * tiltForce, 50));
    }
}
