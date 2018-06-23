using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood_Rotate : MonoBehaviour {
    public GameObject wood;
    public int speed;
	
	// Update is called once per frame
	void Update () {
        wood.transform.Rotate(0, speed, 0);
	}
}
