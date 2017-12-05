using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	void Awake()
	{
		//Causes UI object not to be destroyed when loading a new scene. If you want it to be destroyed, destroy it manually via script.
	    int uiLength = FindObjectsOfType<UI>().Length;
	    if (uiLength > 1)
	    {
	        Destroy(this.gameObject);
	    }
	    else
	    {
	        DontDestroyOnLoad(this.gameObject);
	    }
	}

    void Start()
    {
        GameObject gobj = GameObject.Find("UI/MenuPanel");
        gobj.SetActive(true);
    }
	

}
