using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engulfer : MonoBehaviour {

    public Transform U100;
    public Transform U75;

    public Transform U50;
    public Transform U25;
    // Use this for initialization
    void Start () {

        for (int i = 0; i < 10; i++)
        {

            Instantiate(U100, new Vector3(Mathf.Floor( Random.Range(-5.0f, 5.0f)),0, Mathf.Floor(Random.Range(-5.0f, 5.0f))), Quaternion.AngleAxis(90, new Vector3(0,1,0)));
            Instantiate(U75, new Vector3(Mathf.Floor(Random.Range(-5.0f, 5.0f)), 0, Mathf.Floor(Random.Range(-5.0f, 5.0f))), Quaternion.identity);
            Instantiate(U50, new Vector3(Mathf.Floor(Random.Range(-5.0f, 5.0f)), 0, Mathf.Floor(Random.Range(-5.0f, 5.0f))), Quaternion.AngleAxis(90, new Vector3(0, 1, 0)));
            Instantiate(U25, new Vector3(Mathf.Floor(Random.Range(-5.0f, 5.0f)), 0, Mathf.Floor(Random.Range(-5.0f, 5.0f))), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
