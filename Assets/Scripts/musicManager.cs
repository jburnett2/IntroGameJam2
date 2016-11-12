using UnityEngine;
using System.Collections;

public class musicManager : MonoBehaviour {

    private AudioSource source;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
    void Awake()
    {
        source.PlayOneShot(source.clip, .2f);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
