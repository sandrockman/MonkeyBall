using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StoreScript : MonoBehaviour {

    public Text BananaText;

	// Use this for initialization
	void Start () {
        BananaText.text = "Bananas: " + PlayerPrefs.GetInt("TotalBananas");
	}
	
}
