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

    public float BatSpeed;
    public float HangarXPos;
    public float HangarYPos;
    public int GenerationFrequencyPercent;
    


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

        hangar.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1 * BatSpeed * (seed / 5f), 0));
        hangar.transform.position += new Vector3(HangarXPos * (seed / 5), HangarYPos * (seed / 5), 0f);
        bats.Add(BatOnWire.GetComponent<BatDeleter>());
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        int randy = Random.Range(0, 100);

        if (randy > 100 - GenerationFrequencyPercent)
        {
            Generate();
        }

        


    }

    public void deleteBat(BatDeleter bat)
    {
        bats.Remove(bat);
    }
}
