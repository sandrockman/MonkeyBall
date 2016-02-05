using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void _QuitButton()
    {
        Debug.Log("Quit Button Pressed");
        Application.Quit();
    }

    public void _MainMenuButton()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void _HowToPlayButton()
    {
        SceneManager.LoadScene("HowToPlayScene");
    }

    public void _LevelSelectButton()
    {
        SceneManager.LoadScene("LevelSelectScene");
    }

    public void _StoreButton()
    {
        SceneManager.LoadScene("StoreScene");
    }

    public void _CreditsButton()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void _Level1Button()
    {
        SceneManager.LoadScene("Level1");
    }

    public void _Level2Button()
    {
        SceneManager.LoadScene("Level2");
    }

    public void _Level3Button()
    {
        SceneManager.LoadScene("Level3");
    }

    public void _Level4Button()
    {
        SceneManager.LoadScene("Level4");
    }

    public void _Level5Button()
    {
        SceneManager.LoadScene("Level5");
    }


}
