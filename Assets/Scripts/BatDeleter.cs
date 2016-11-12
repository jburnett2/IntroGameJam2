using UnityEngine;
using System.Collections;

public class BatDeleter : MonoBehaviour
{


    //Vector3 PivotLoc;


    GameObject bat;
    public bool dead;
    void Start()
    {
        dead = false;
        bat = transform.FindChild("bestbat").gameObject;
    }

    void Update()
    {
        if (bat.transform.position.x < -100)
        {
            StartCoroutine(waitDestroy(0));
        }
        if (dead == true)
        {
            StartCoroutine(waitDestroy(5));
        }
        
    }
    IEnumerator waitDestroy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        GameObject.Find("BatSpawner").GetComponent<BatAttack>().deleteBat(this);
        GameObject.Destroy(gameObject);
    }

}