using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secar : MonoBehaviour {
	public Material arbolVivo;
	public Material arbolMuerto;
    public Material vacio;
    public float secar = 5f;

	// Use this for initialization
	public void Start () {
		gameObject.GetComponent<Renderer>().material = vacio;
		
	}
	
	// Update is called once per frame
	public void Update () {
        secar = secar + 1 + Time.fixedDeltaTime;
        if(secar > 500)
            gameObject.GetComponent<Renderer>().material = arbolVivo;
        if (Input.GetKeyDown ("space"))
			gameObject.GetComponent<Renderer>().material = arbolMuerto;
		
	}
}
