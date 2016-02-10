using UnityEngine;
using System.Collections;

public class SetPrefs : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (!PlayerPrefs.HasKey("Level1TotalTime"))
            PlayerPrefs.SetFloat("Level1TotalTime", 0f);
        if (!PlayerPrefs.HasKey("Level1Plays"))
            PlayerPrefs.SetFloat("Level1Plays", 0f);


        if (!PlayerPrefs.HasKey("Level2TotalTime"))
            PlayerPrefs.SetFloat("Level2TotalTime", 0f);
        if (!PlayerPrefs.HasKey("Level2Plays"))
            PlayerPrefs.SetFloat("Level2Plays", 0f);


        if (!PlayerPrefs.HasKey("Level3TotalTime"))
            PlayerPrefs.SetFloat("Level3TotalTime", 0f);
        if (!PlayerPrefs.HasKey("Level3Plays"))
            PlayerPrefs.SetFloat("Level3Plays", 0f);

        if (!PlayerPrefs.HasKey("Level4TotalTime"))
            PlayerPrefs.SetFloat("Level4TotalTime", 0f);
        if (!PlayerPrefs.HasKey("Level4Plays"))
            PlayerPrefs.SetFloat("Level4Plays", 0f);

        if (!PlayerPrefs.HasKey("Level5TotalTime"))
            PlayerPrefs.SetFloat("Level5TotalTime", 0f);
        if (!PlayerPrefs.HasKey("Level5Plays"))
            PlayerPrefs.SetFloat("Level5Plays", 0f);

        if (!PlayerPrefs.HasKey("TotalBananas"))
            PlayerPrefs.SetInt("TotalBananas", 0);

    }

}
