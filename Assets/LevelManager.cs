using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public GameObject[] levels = new GameObject[3];

    private int progression = 0;

    // Update is called once per frame
    void Update () {
		Progression();
	}

    public void IncreaseLevel(int index)
    {
        Debug.Log("Increased");
        progression= index;
    }

    private void Progression()
    {
        for (int i = 0; i < levels.Length; i++)
        {
            if (i <= progression)
            {
                levels[i].GetComponent<Button>().interactable = true;
            }
        }
    }
}
