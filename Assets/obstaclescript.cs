using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclescript : MonoBehaviour
{

    public float styrke = 4f;
    public float fart = 2f;

    private float randomOs;

	// Use this for initialization
	void Start ()
	{
	    randomOs = Random.Range(0f, 2f);
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 pos = transform.position;
	    pos.x = Mathf.Sin(Time.time * fart + randomOs) * styrke;
	    transform.position = pos;
	}
}
