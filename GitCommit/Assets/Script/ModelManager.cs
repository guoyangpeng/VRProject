using UnityEngine;
using System.Collections;

public class ModelManager : MonoBehaviour
{

    private float a = 1.0000001f;

	void Start () {
	    Debug.Log("hellowzdasdasd大大声地orld");
	}
	
	void Update () {
	    transform.Rotate(Vector3.up, Time.deltaTime * 30);
	}
}
