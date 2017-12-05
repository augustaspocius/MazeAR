using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    private GameObject LevelManager;

    private LevelManager levelmanager;

    private bool found = false;
    private bool assigned = false;
    private bool increased;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Initialize CompleteLevel");
        increased = false;

    }
	
	// Update is called once per frame
	void Update () {
	    if (!found && !assigned)
	    {
	        LevelManager = GameObject.Find("UI/LevelManager");
	        if (LevelManager)
            { 
	            Debug.Log("FOUND");
	        
                found = true;
	        }
	    }
	    else if(found && !assigned)
	    {
	        levelmanager = LevelManager.GetComponent<LevelManager>();
	        if (levelmanager)
	        {
	            Debug.Log("ASSIGNED");
	            assigned = true;
            }
	    }
	}

    void OnTriggerEnter(Collider col)
    {
        if (!increased)
        {
            levelmanager.IncreaseLevel(SceneManager.GetActiveScene().buildIndex);
            increased = true;
        }
    }
}
