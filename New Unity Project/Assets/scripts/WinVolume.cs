using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinVolume : MonoBehaviour {

    public enum LevelName { Level1, Level2, Level3, Level4, Level5};

    public LevelName levelName;

    public GameObject victoryObj;
    public GameObject outOfTimeObj;
    public GameObject endLevelObj;

    public Text timer;
    public Text bananaCounterText;
    public float timeLimit = 60f;

    private bool countDown = true;

    private float startTime;

    void Awake()
    {
        startTime = Time.time;
        CountBananas.bananaCount = 0;
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
            //add to banana count
            int tempBananas = PlayerPrefs.GetInt("TotalBananas");
            PlayerPrefs.SetInt("TotalBananas", tempBananas + CountBananas.bananaCount);
            //increment appropriate times
            float endTime = Time.time - startTime;
            SceneClearTimeIncrement(endTime);
        }
    }

	// Update is called once per frame
	void Update () {
	    if(countDown)
        {
            int bananaTotal = PlayerPrefs.GetInt("TotalBananas") + CountBananas.bananaCount;
            bananaCounterText.text = bananaTotal.ToString();
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

    /// <summary>
    /// finds the appropriate level average data and increments it.
    /// </summary>
    /// <param name="timeToAdd"></param>
    void SceneClearTimeIncrement(float timeToAdd)
    {
        float tempTime, tempAvgCount;
        switch(levelName)
        {
            case LevelName.Level1:
                tempTime = PlayerPrefs.GetFloat("Level1TotalTime");
                PlayerPrefs.SetFloat("Level1TotalTime", tempTime + timeToAdd);
                tempAvgCount = PlayerPrefs.GetFloat("Level1Plays");
                PlayerPrefs.SetFloat("Level1Plays", tempAvgCount + 1);
                break;
            case LevelName.Level2:
                tempTime = PlayerPrefs.GetFloat("Level2TotalTime");
                PlayerPrefs.SetFloat("Level2TotalTime", tempTime + timeToAdd);
                tempAvgCount = PlayerPrefs.GetFloat("Level2Plays");
                PlayerPrefs.SetFloat("Level2Plays", tempAvgCount + 1);
                break;
            case LevelName.Level3:
                tempTime = PlayerPrefs.GetFloat("Level3TotalTime");
                PlayerPrefs.SetFloat("Level3TotalTime", tempTime + timeToAdd);
                tempAvgCount = PlayerPrefs.GetFloat("Level3Plays");
                PlayerPrefs.SetFloat("Level3Plays", tempAvgCount + 1);
                break;
            case LevelName.Level4:
                tempTime = PlayerPrefs.GetFloat("Level4TotalTime");
                PlayerPrefs.SetFloat("Level4TotalTime", tempTime + timeToAdd);
                tempAvgCount = PlayerPrefs.GetFloat("Level4Plays");
                PlayerPrefs.SetFloat("Level4Plays", tempAvgCount + 1);
                break;
            case LevelName.Level5:
                tempTime = PlayerPrefs.GetFloat("Level5TotalTime");
                PlayerPrefs.SetFloat("Level5TotalTime", tempTime + timeToAdd);
                tempAvgCount = PlayerPrefs.GetFloat("Level5Plays");
                PlayerPrefs.SetFloat("Level5Plays", tempAvgCount + 1);
                break;
            default:
                break;
        }
    }
}
