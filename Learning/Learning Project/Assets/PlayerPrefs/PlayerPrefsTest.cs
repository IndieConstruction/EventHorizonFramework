using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerPrefsTest : MonoBehaviour {

    public InputField NameInput;
    public Text NameLable;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetString("MyName") != null) {
            NameLable.text = PlayerPrefs.GetString("MyName") + " Lev: " + PlayerPrefs.GetInt("Level");
        }
	}
	
	// Update is called once per frame
	void Update () {
        
            
            
	}

    public void SaveProfile() {
        PlayerPrefs.SetString("MyName", NameInput.text);
        PlayerPrefs.SetInt("Level", 1);
        PlayerPrefs.Save();
    }
}
