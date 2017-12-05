using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Pause : MonoBehaviour {


	private ShowPanels showPanels;						//Reference to the ShowPanels script used to hide and show UI panels
	private bool isPaused;								//Boolean to check if the game is paused or not
    private bool clicked;
	private StartOptions startScript;					//Reference to the StartButton script
    private Button pausebttn;
    private GameObject UI;
    private GameObject resume;

    //Awake is called before Start()
    void Awake()
	{
	    UI = GameObject.Find("UI");
		//Get a component reference to ShowPanels attached to this object, store in showPanels variable
		showPanels = UI.GetComponent<ShowPanels> ();
		//Get a component reference to StartButton attached to this object, store in startScript variable
		startScript = UI.GetComponent<StartOptions> ();
	    pausebttn = GetComponent<Button>();
        pausebttn.onClick.AddListener(Clicked);
	}

	// Update is called once per frame
	void Update () {

		//Check if the Cancel button in Input Manager is down this frame (default is Escape key) and that game is not paused, and that we're not in main menu
		if (!isPaused && clicked && !startScript.inMainMenu)
		{
		    clicked = false;
			//Call the DoPause function to pause the game
			DoPause();
		} 
	
	}

    void Clicked()
    {
        isPaused = false;
        clicked = true;
    }

	public void DoPause()
	{
		//Set isPaused to true
		isPaused = true;
		//Set time.timescale to 0, this will cause animations and physics to stop updating
		Time.timeScale = 0;
        //GameObject scroll = GameObject.Find("");
		//call the ShowPausePanel function of the ShowPanels script
		showPanels.ShowPausePanel ();
	}


	public void UnPause()
	{
		//Set isPaused to false
		isPaused = false;
		//Set time.timescale to 1, this will cause animations and physics to continue updating at regular speed
		Time.timeScale = 1;
		//call the HidePausePanel function of the ShowPanels script
		showPanels.HidePausePanel ();
	}


}
