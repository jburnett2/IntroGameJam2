using UnityEngine;
using System.Collections;

public class BatDeleter : MonoBehaviour
{


    //Vector3 PivotLoc;


    GameObject bat;
    void Start()
    {
        bat = transform.FindChild("bestbat").gameObject;
    }

    void Update()
    {
        if (bat.transform.position.x < -100)
        {
            GameObject.Find("BatSpawner").GetComponent<BatAttack>().deleteBat(this);
            GameObject.Destroy(gameObject);
        }
    }

}