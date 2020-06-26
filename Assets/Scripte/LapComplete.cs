using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
	public int LapsDone;

	public GameObject RaceFinish;
	public GameObject LapCounter;

    void OnTriggerEnter()
    {       
		LapsDone += 1;
		if (LapsDone == 2) {
			RaceFinish.SetActive(true);
		}
		
		LapCounter.GetComponent<Text> ().text = "" + LapsDone;
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
}

