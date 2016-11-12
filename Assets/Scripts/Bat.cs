using UnityEngine;
using System.Collections;

public class Bat : MonoBehaviour
{
    private Rigidbody2D theRigidBody;

    void Start ()
    {
        theRigidBody = GetComponent<Rigidbody2D>();
    }

    //Vector3 PivotLoc;
    public Sprite deadBat;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("AAAAAH");
        if (gameObject.transform.parent.gameObject.GetComponent<BatDeleter>().dead == false)
        {
            theRigidBody.velocity = new Vector2(0, 0);
            theRigidBody.AddForce(new Vector2(0, 400));
        }
        Destroy(gameObject.GetComponent<HingeJoint2D>());
        gameObject.GetComponent<SpriteRenderer>().sprite = deadBat;
        gameObject.transform.parent.gameObject.GetComponent<BatDeleter>().dead = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            if (gameObject.transform.parent.gameObject.GetComponent<BatDeleter>().dead == false)
            {
                theRigidBody.velocity = new Vector2(0, 0);
                theRigidBody.AddForce(new Vector2(0, 400));
            }
            Destroy(gameObject.GetComponent<HingeJoint2D>());
            gameObject.GetComponent<SpriteRenderer>().sprite = deadBat;
            gameObject.transform.parent.gameObject.GetComponent<BatDeleter>().dead = true;
        }
    }
    void FixedUpdate()
    {

    }

}