using UnityEngine;
using System.Collections;

public class background_game : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape"))
            Application.Quit();
        if (Input.GetKey("c"))
            Application.LoadLevel("credits");
	}
}
