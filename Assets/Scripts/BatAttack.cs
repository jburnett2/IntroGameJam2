using UnityEngine;
using System.Collections;

public class BatAttack : MonoBehaviour {

    GameObject Bat;

	// Use this for initialization
	void Start () {

        Bat = Resources.Load<GameObject>("Prefabs/bestbat");

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
