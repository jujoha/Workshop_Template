using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {

	public GameObject MyCar;

	void OnTriggerEnter () {
		this.GetComponent<BoxCollider> ().enabled = false;
        
		//self
		//MyCar.GetComponent<CarController> ().enabled = false;

		//AI
        MyCar.GetComponent<CarAIControl>().m_Driving = false;

    }

}
