using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour {

    public float speed = 5f;
    public Rigidbody rb;
    public bool onBarrel;
    public Knife_Spawn spawn;
	// Use this for initialization
	void Start () {
       
        onBarrel = false;
        
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space) && onBarrel==false)
        {
            rb.velocity = new Vector3(0, speed, 0);
                } 

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Barrel")
        {
            gameObject.transform.SetParent(other.transform);
            rb.velocity = Vector3.zero;
            this.onBarrel = true;
            spawn.mustNew = true;
            rb.detectCollisions = false;            
        }
        if(other.tag=="Knife")
        {
            Debug.Log("You Lose");
        }
    }

}
