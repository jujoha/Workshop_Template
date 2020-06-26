using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRoute : MonoBehaviour {

	public GameObject InitialPoint;
	public GameObject Point01;
	public GameObject Point02;
	public GameObject Point03;
	public GameObject Point04;
	public GameObject Point05;
	public GameObject Point06;
    public GameObject Point07;
	public int MarkTracker;


	// Update is called once per frame
	void Update () {
		if (MarkTracker == 0) {
			InitialPoint.transform.position = Point01.transform.position;
		}
		if (MarkTracker == 1) {
			InitialPoint.transform.position = Point02.transform.position;
		}
		if (MarkTracker == 2) {
			InitialPoint.transform.position = Point03.transform.position;
		}
		if (MarkTracker == 3) {
			InitialPoint.transform.position = Point04.transform.position;
		}
		if (MarkTracker == 4) {
			InitialPoint.transform.position = Point05.transform.position;
		}
		if (MarkTracker == 5) {
			InitialPoint.transform.position = Point06.transform.position;
		}
        if(MarkTracker == 6)
        {
            InitialPoint.transform.position = Point07.transform.position;
        }
	}

	IEnumerator OnTriggerEnter (Collider collision) {
		if (collision.gameObject.tag == "Dreamcar01") {
			this.GetComponent<BoxCollider> ().enabled = false;
			MarkTracker += 1;
			if (MarkTracker == 7) {
				MarkTracker = 0;
			}
			yield return new WaitForSeconds (1);
			this.GetComponent<BoxCollider> ().enabled = true;
		}
	}

}
