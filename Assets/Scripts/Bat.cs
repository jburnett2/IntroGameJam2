using UnityEngine;
using System.Collections;

public class Bat : MonoBehaviour
{


    //Vector3 PivotLoc;
    public Sprite deadBat;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("AAAAAH");
        Destroy(gameObject.GetComponent<HingeJoint2D>());
        gameObject.GetComponent<SpriteRenderer>().sprite = deadBat;
        gameObject.transform.parent.gameObject.GetComponent<BatDeleter>().dead = true;
    }
    void FixedUpdate()
    {

    }

}