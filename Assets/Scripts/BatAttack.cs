using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BatAttack : MonoBehaviour {

    BatDeleter bestTestBat;
    List<BatDeleter> bats;
    GameObject BatOnWirePrefab;
    GameObject BatOnWire;
    Transform BatObject;
    Vector3 BatWireLoc;


    // Use this for initialization
    void Start () {
        bats = new List<BatDeleter>();
        BatOnWirePrefab = Resources.Load<GameObject>("Prefabs/BatOnAWire");


    }
    void Generate()
    {
        //This seed determines the hangar's speed, location, and distance from bats
        float seed = Random.Range(1f, 10f);

        //Sets the starting location for ALL bats - needs to be adjusted based on final camera size and location.
        BatWireLoc = new Vector3(-17, 17, 0);

        BatOnWire = (GameObject)Instantiate(BatOnWirePrefab, BatWireLoc, Quaternion.identity);
        BatObject = BatOnWire.transform.FindChild("bestbat");


        Transform hangar = BatOnWire.transform.FindChild("BatHangar");

        hangar.GetComponent<Rigidbody2D>().AddForce(new Vector2(-4000 * (seed / 5f), 0));
        hangar.transform.position += new Vector3(-10 * seed, -10 * seed, 0f);
        bats.Add(BatOnWire.GetComponent<BatDeleter>());
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        int randy = Random.Range(0, 100);

        if (randy > 98)
        {
            Generate();
            randy = Random.Range(0, 100);
        }

        


    }

    public void deleteBat(BatDeleter bat)
    {
        bats.Remove(bat);
    }
}
