using UnityEngine;
using System.Collections;

public class ModelManager : MonoBehaviour {

	void Start () {
	    Debug.Log("helloworld");
	}
	
	void Update () {
	    transform.Rotate(Vector3.up, Time.deltaTime * 30);
	}
}
