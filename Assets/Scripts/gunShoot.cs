using UnityEngine;
using System.Collections;

public class gunShoot : MonoBehaviour {

    public float bulletSpeed;

    public GameObject bulletObj;
    private bullet bScript;

	// Use this for initialization
	void Start () {
        bScript = GetComponent<bullet>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject iBullet = (GameObject)Instantiate(bulletObj, transform.position, transform.rotation);
            Rigidbody2D rb = iBullet.GetComponent<Rigidbody2D>();
            //rb.velocity = bulletSpeed;
        }
	}
}
