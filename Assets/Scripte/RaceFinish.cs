using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {

	public GameObject MyCar;
	public GameObject CompleteTrig;

	void OnTriggerEnter () {
		this.GetComponent<BoxCollider> ().enabled = false;
		CompleteTrig.SetActive (false);
        MyCar.SetActive(false);
		CarController.m_Topspeed = 0.0f;
		MyCar.GetComponent<CarController> ().enabled = false;
		//only when not using the waypointbased car
        //MyCar.GetComponent<CarUserControl> ().enabled = false;
		MyCar.GetComponent<CarAudio> ().enabled = false;
        MyCar.GetComponent<CarAIControl>().m_Driving = false;
        MyCar.GetComponent<CarAIControl>().enabled = false;
        MyCar.SetActive(true);
    }

}
