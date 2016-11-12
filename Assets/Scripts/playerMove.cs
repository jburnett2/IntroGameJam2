using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Physics.IgnoreLayerCollision(8, 9, true); // 8 and 9 are layerID's for player and legs, true sets ignoring to true
	}
}
