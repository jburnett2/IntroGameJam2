using UnityEngine;
using System.Collections;

public class Scrolling : MonoBehaviour {

	public float scrollSpeed;
	private Vector2 savedOffset;

	// Use this for initialization
	void Start () {
		savedOffset = GetComponent<SpriteRenderer>().sharedMaterial.GetTextureOffset ("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
		float x = Mathf.Repeat (Time.time * scrollSpeed, 1);
		Vector2 offset = new Vector2 (x, savedOffset.y);
		GetComponent<SpriteRenderer>().sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}

	void OnDisable(){
		GetComponent<SpriteRenderer>().sharedMaterial.SetTextureOffset ("_MainTex",savedOffset);
	}
}
