using UnityEngine;
using System.Collections;

public class Camera_test : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        transform.position = new Vector3(
            Camera.main.orthographicSize * Camera.main.aspect, Camera.main.orthographicSize);
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
