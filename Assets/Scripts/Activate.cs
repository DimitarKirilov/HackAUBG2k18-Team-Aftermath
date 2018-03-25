using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour {
    public Transform origin;
    public Transform target;
    public float moveToSpeed;
    public Canvas canvas;
    private Transform transform;

	// Use this for initialization
	void Start () {
        GameObject canvas = GetComponent<GameObject>();
	}

    public void disableCanvas()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target.position, moveToSpeed);
        canvas.gameObject.SetActive(false);
    }

    public void enableCanvas()
    {
       //transform.position = Vector3.MoveTowards(transform.position, target.position, moveToSpeed);
        canvas.gameObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
