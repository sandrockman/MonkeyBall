using UnityEngine;
using System.Collections;

public class BananaBounce : MonoBehaviour {

    public float bobSpeed = 1.5f;
    public float bobHeight = 0.75f;
    public float spinSpeed = 180f;

    public Transform bobber;

    public int health = 3;
    public float divider = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(bobber != null)
        {
            float newPos = Mathf.PingPong(Time.time * bobSpeed, bobHeight);
            bobber.localPosition = Vector3.up * newPos;
        }

        transform.Rotate(Vector3.up * Time.deltaTime * spinSpeed);
	}

    public void Touched()
    {
        health--;
        bobSpeed /= divider;
        spinSpeed /= divider;

        if (health <= 0)
        {
            CountBananas.bananaCount++;
            Destroy(gameObject);
        }
    }
}
