using UnityEngine;
using System.Collections;

public class MonkeyBall : MonoBehaviour {

    public Rigidbody body;
    public float minTilt = 5f;
    public float sensitivity = 1f;

    public Transform monkeyPivot;
    public float monkeyLookSpeed = 10f;

    public bool isCentering = false;

    Vector3 totalRotation = Vector3.zero;

    void Awake()
    {
        Input.gyro.enabled = true;

        if (SystemInfo.supportsGyroscope)
        {
        }
        else
        {
            Application.Quit();
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 rotation = Input.gyro.rotationRate * Mathf.Rad2Deg;

        if (Mathf.Abs(rotation.x) < minTilt)
            rotation.x = 0;

        if (Mathf.Abs(rotation.y) < minTilt)
            rotation.y = 0;

        if (Mathf.Abs(rotation.z) < minTilt)
            rotation.z = 0;

        totalRotation += new Vector3(rotation.x, rotation.z, rotation.y) * Time.deltaTime;
        
    }

    void FixedUpdate()
    {
        if(isCentering)
        {
            body.angularVelocity = Vector3.zero;
            totalRotation = Vector3.zero;
            isCentering = false;
        }
        else
        body.AddTorque(totalRotation * sensitivity);
    }

    void LateUpdate()
    {
        if(monkeyPivot != null)
        {
            //which direction is ball moving
            Vector3 velocity = body.velocity;
            //Zero out the y so monkey does not look up/down
            velocity.y = 0f;

            //Determine direction monkey is facing
            Vector3 forward = monkeyPivot.forward;
            forward.y = 0f;

            //Frame Rate independent
            float step = monkeyLookSpeed * Time.deltaTime;

            //Rotate the monkey in the new direction
            //Vector3.RotateTowards(Currentfacing, desired Movement, speed, (ignore this));
            Vector3 newFacing = Vector3.RotateTowards(forward, velocity, step, 0f);

            monkeyPivot.rotation = Quaternion.LookRotation(newFacing);
        }
    }

    public void _CenterButton()
    {
        isCentering = true;
        body.angularVelocity = Vector3.zero;
        totalRotation = Vector3.zero;
        Debug.Log("Angular Velocity: " + body.angularVelocity);
    }
}
