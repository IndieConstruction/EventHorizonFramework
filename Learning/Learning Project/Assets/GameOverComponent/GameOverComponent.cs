using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverComponent : MonoBehaviour {

    private bool isActive;

    public bool IsActive
    {
        get { return isActive; }
        set {
            //if(isActive != value) {
                if (State == GameOverState.Lost)
                {
                    TitleText.text = "You Lost!!";
                    NextLevelButton.gameObject.SetActive(false);
                    RestartLevelButton.gameObject.SetActive(true);
                }
                else {
                    TitleText.text = "You Win!!";
                    NextLevelButton.gameObject.SetActive(true);
                    RestartLevelButton.gameObject.SetActive(false);
                }
                GetComponent<Animator>().SetBool("IsActive", isActive);
            //}
            isActive = value;
            
        }
    }

    public enum GameOverState { Win, Lost }
    public GameOverState State;
    public Text TitleText;
    public Button NextLevelButton;
    public Button RestartLevelButton;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Logica
    public void SetWindowVisible(bool _visible) {
        IsActive = _visible;
    }
}
