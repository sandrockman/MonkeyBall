using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinVolume : MonoBehaviour {

    public GameObject victoryObj;
    public GameObject outOfTimeObj;
    public GameObject endLevelObj;

    public Text timer;
    public float timeLimit = 60f;

    private bool countDown = true;

    void Awake()
    {
        victoryObj.SetActive(false);
        outOfTimeObj.SetActive(false);
        endLevelObj.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (countDown)
        {
            victoryObj.SetActive(true);
            endLevelObj.SetActive(true);
            other.attachedRigidbody.isKinematic = true;
            countDown = false;
        }
    }

	// Update is called once per frame
	void Update () {
	    if(countDown)
        {
            timeLimit -= Time.deltaTime;
            timer.text = timeLimit.ToString("0.00");
        }

        if(timeLimit <= 0f)
        {
            outOfTimeObj.SetActive(true);
            endLevelObj.SetActive(true);
            timer.gameObject.SetActive(false);
            countDown = false;
        }
	}
}
