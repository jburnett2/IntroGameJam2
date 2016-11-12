using UnityEngine;
using System.Collections;

public class BatAttack : MonoBehaviour {

    public Bat bestTestBat;

    public class Bat {
        public
        Bat(Vector3 startingLoc) { loc = startingLoc; }

        Vector3 loc;
        GameObject BatObj;



        public void Generate() {
            BatObj = Resources.Load<GameObject>("Prefabs/bestbat");
            BatObj = (GameObject)Instantiate(BatObj, new Vector3(1, 1, 2), Quaternion.identity);
        }

        public void Jitter() {

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
	void Update () {

    }
}
