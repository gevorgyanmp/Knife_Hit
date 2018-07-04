using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife_Spawn : MonoBehaviour {

    public GameObject knife;
    public bool isKnife;
    public bool mustNew;
    public GameObject parentObject;
    
    // Use this for initialization
    void Start () {
       
        isKnife = true;
        mustNew = false;
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Space) )
            {
            isKnife = false;
        }
        if (isKnife == false && mustNew == true)
        {
            
            GameObject childObject = Instantiate(knife, transform.position, transform.rotation);
            childObject.transform.parent = parentObject.transform;
            childObject.transform.localScale = new Vector3(1, 1, 1);
            isKnife = true;
            mustNew = false;
        }

	}
}
