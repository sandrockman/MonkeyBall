using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplayScript : MonoBehaviour {

    public Text Level1AvgText;
    public Text Level1TriesText;

    public Text Level2AvgText;
    public Text Level2TriesText;

    public Text Level3AvgText;
    public Text Level3TriesText;

    public Text Level4AvgText;
    public Text Level4TriesText;

    public Text Level5AvgText;
    public Text Level5TriesText;

    float level1Avg, level2Avg, level3Avg, level4Avg, level5Avg;
    float level1Tries, level2Tries, level3Tries, level4Tries, level5Tries;

    // Use this for initialization
    void Start () {
        PullPlayerPrefs();
	}
	
	void PullPlayerPrefs()
    {
        level1Tries = PlayerPrefs.GetFloat("Level1Plays");
        level2Tries = PlayerPrefs.GetFloat("Level2Plays");
        level3Tries = PlayerPrefs.GetFloat("Level3Plays");
        level4Tries = PlayerPrefs.GetFloat("Level4Plays");
        level5Tries = PlayerPrefs.GetFloat("Level5Plays");

        level1Avg = FindAvg(PlayerPrefs.GetFloat("Level1TotalTime") , level1Tries);
        level2Avg = FindAvg(PlayerPrefs.GetFloat("Level2TotalTime") , level2Tries);
        level3Avg = FindAvg(PlayerPrefs.GetFloat("Level3TotalTime") , level3Tries);
        level4Avg = FindAvg(PlayerPrefs.GetFloat("Level4TotalTime") , level4Tries);
        level5Avg = FindAvg(PlayerPrefs.GetFloat("Level5TotalTime") , level5Tries);

        Level1AvgText.text = string.Format("AVG Time\n{0:f2}", level1Avg);
        Level1TriesText.text = string.Format("X Done:\n{0:f0}", level1Tries);

        Level2AvgText.text = string.Format("AVG Time\n{0:f2}", level2Avg);
        Level2TriesText.text = string.Format("X Done:\n{0:f0}", level2Tries);

        Level3AvgText.text = string.Format("AVG Time\n{0:f2}", level3Avg);
        Level3TriesText.text = string.Format("X Done:\n{0:f0}", level3Tries);

        Level4AvgText.text = string.Format("AVG Time\n{0:f2}", level4Avg);
        Level4TriesText.text = string.Format("X Done:\n{0:f0}", level4Tries);

        Level5AvgText.text = string.Format("AVG Time\n{0:f2}", level5Avg);
        Level5TriesText.text = string.Format("X Done:\n{0:f0}", level5Tries);


    }

    float FindAvg(float total, float divider)
    {
        if (divider <= 0)
            return 0;
        else
            return total / divider;
    }
}
