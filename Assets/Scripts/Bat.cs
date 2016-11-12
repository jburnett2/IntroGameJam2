using UnityEngine;
using System.Collections;

public class Bat : MonoBehaviour
{


    //Vector3 PivotLoc;
    public Sprite deadBat;

    void Start() {
        //deadBat = Resources.Load("Sprites/deadestbat") as Sprite;
            }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("AAAAAH");
        Destroy(gameObject.GetComponent<HingeJoint2D>());
        gameObject.GetComponent<SpriteRenderer>().sprite = deadBat;
    }

}