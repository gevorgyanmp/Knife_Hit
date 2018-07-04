using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Wood_Rotate : MonoBehaviour {
    public GameObject wood;
    public int speed;
    public GameObject knife;
    public Rigidbody rb;
    public float a;
    public float b;
    public float c;
    public float y;

    public void CreateKinfe()
    {
        a = Random.Range(-0.495f, 0.495f);
        c = 0.495f;
        b = Mathf.Sqrt(Mathf.Pow(c, 2) - Mathf.Pow(a, 2));
        y = Mathf.Sin(a / c) * 180 / Mathf.PI;
        y = -y;
        GameObject child = Instantiate(knife, transform.position, transform.rotation);
        child.transform.parent = wood.transform;
        child.transform.Translate(Vector3.forward * -a);
        child.transform.Translate(Vector3.right * -b);
        child.transform.localEulerAngles = new Vector3(0, y, 0);
        child.transform.localScale = new Vector3(2, 2, 2);
        rb.detectCollisions = false;
        rb.velocity = Vector3.zero;
    }

    private void Start()
    {
      for (int i=0; i<3; i++)
        {
            CreateKinfe();
        }
            

        
            
        
        
    }

    // Update is called once per frame
    void Update () {
        wood.transform.Rotate(0, speed, 0);
	}
}
