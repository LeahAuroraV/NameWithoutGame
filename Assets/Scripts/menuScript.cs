using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {
    public Canvas exitConfirm;
    public Button startText;
    public Button exitText;
	// Use this for initialization
	void Start () {
        exitConfirm = exitConfirm.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        exitConfirm.enabled = false;
	}
	
	// Update is called once per frame
    public void ExitPress() {
        exitConfirm.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }
    public void NoPress() {
        exitConfirm.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }
}
