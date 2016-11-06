using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {

	[System.Serializable]
	public class CannonControls{
		public KeyCode fireKey = KeyCode.Space;
		public KeyCode rotateLeftKey = KeyCode.LeftArrow;
		public KeyCode rotateRightKey = KeyCode.RightArrow;
		public KeyCode rotateUpKey = KeyCode.UpArrow;
		public KeyCode rotateDownKey = KeyCode.DownArrow;
	}

	public CannonControls controls = new CannonControls();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void LateUpdate(){
			
	}

	void Fire(){
	}
}
