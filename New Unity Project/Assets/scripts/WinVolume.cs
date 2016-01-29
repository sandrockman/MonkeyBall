using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinVolume : MonoBehaviour {

    public GameObject victoryText;
    public GameObject outOfTimeText;

    public Text timer;
    public float timeLimit = 60f;

    private bool countDown = true;

    void Awake()
    {
        victoryText.SetActive(false);
        outOfTimeText.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (countDown)
        {
            victoryText.SetActive(true);
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
            outOfTimeText.SetActive(true);
            timer.gameObject.SetActive(false);
            countDown = false;
        }
	}
}
