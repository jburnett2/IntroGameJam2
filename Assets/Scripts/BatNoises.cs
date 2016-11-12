using UnityEngine;
using System.Collections;

public class BatNoises : MonoBehaviour {

    private AudioSource source;
    private AudioClip alex;

    private int randy;

    // Use this for initialization
    void Start () {

        randy = Random.Range(0, 90);


            alex = Resources.Load<AudioClip>("Sounds/AlexJones/animated");
        if (randy >= 10)
            alex = Resources.Load<AudioClip>("Sounds/AlexJones/explorer");
        if (randy >= 20)
            alex = Resources.Load<AudioClip>("Sounds/AlexJones/human");
        if (randy >= 30)
            alex = Resources.Load<AudioClip>("Sounds/AlexJones/iliketoEAT");
        if (randy >= 40)
            alex = Resources.Load<AudioClip>("Sounds/AlexJones/iliketoHAVECHILDREN");
        if (randy >= 50)
            alex = Resources.Load<AudioClip>("Sounds/AlexJones/imcoming");
        if (randy >= 60)
            alex = Resources.Load<AudioClip>("Sounds/AlexJones/LIFEFORCE");
        if (randy >= 70)
            alex = Resources.Load<AudioClip>("Sounds/AlexJones/myheartsBIG");
        if (randy >= 80)
            alex = Resources.Load<AudioClip>("Sounds/AlexJones/pioneer");

        source = GetComponent<AudioSource>();
        source.PlayOneShot(alex, 1f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
