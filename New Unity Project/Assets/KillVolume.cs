using UnityEngine;
using System.Collections;

public class KillVolume : MonoBehaviour {

    public Transform respawnPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = respawnPoint.position;
        other.attachedRigidbody.velocity = Vector3.zero;
    }
}
