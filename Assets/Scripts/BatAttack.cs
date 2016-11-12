using UnityEngine;
using System.Collections;

public class BatAttack : MonoBehaviour {

    public Bat bestTestBat;

    public class Bat {
        public
        Bat(Vector3 startingLoc) { BatLoc = startingLoc; }

        Vector3 BatLoc;
        Vector3 PivotLoc;
        GameObject BatObj;



        public void Generate() {
            BatObj = Resources.Load<GameObject>("Prefabs/BatOnAWire");
            BatObj = (GameObject)Instantiate(BatObj, BatLoc, Quaternion.identity);
            Transform hangar = BatObj.transform.FindChild("BatHangar");
            hangar.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10000,0));
        }


        public void Swoop() {
            BatObj.transform.eulerAngles = new Vector3(0f, 0f, 30f);

        }

    }

	// Use this for initialization
	void Start () {

        bestTestBat = new Bat(new Vector3(1f, 1f, 1f));
        bestTestBat.Generate();
        bestTestBat.Swoop();


    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
    }
}
