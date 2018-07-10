using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour {

    public Text highScore;

	// Use this for initialization
	void Start () {
        highScore.text = PlayerPrefs.GetInt("Hscore").ToString();
        Debug.Log("Current: " + PlayerPrefs.GetInt("Hscore").ToString());
    }
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.Rotate(new Vector3(0,0,2));

	}
    private void OnMouseDown()
    {
        if (gameObject.name == "Play")
        {
            SceneManager.LoadScene("Game");
        }
    }
}
