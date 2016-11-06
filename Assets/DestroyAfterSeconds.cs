using UnityEngine;
using System.Collections;

public class DestroyAfterSeconds : MonoBehaviour {
	public float seconds = 10;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, seconds);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
