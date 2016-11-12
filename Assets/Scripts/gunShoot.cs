using UnityEngine;
using System.Collections;

public class gunShoot : MonoBehaviour {

    public float bulletSpeed;
    public float kickback;

    public GameObject bulletObj;
    private bullet bScript;
    private Transform barrel;
    private Transform back;
    private Rigidbody2D arm;
    private AudioSource source;
    

	// Use this for initialization
	void Start () {
        bScript = GetComponent<bullet>();
        barrel = transform.GetChild(0);
        back = transform.GetChild(1);
        arm = GetComponentInParent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject iBullet = (GameObject)Instantiate(bulletObj, transform.position, transform.rotation);
            if (source.isPlaying)
            {
                source.Stop();
                source.PlayOneShot(source.clip, 1f);
            }
            else
            {
                source.PlayOneShot(source.clip, 1f);
            }
            arm.AddForce(new Vector2((barrel.position.x - back.position.x) * kickback, (barrel.position.y - back.position.y) * kickback));
            Rigidbody2D rb = iBullet.GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2((barrel.position.x - back.position.x)*bulletSpeed, (barrel.position.y - back.position.y)*bulletSpeed));
            iBullet.transform.eulerAngles = new Vector3(0,0, transform.eulerAngles.z+90);
            //rb.velocity = bulletSpeed;
        }
	}
}
