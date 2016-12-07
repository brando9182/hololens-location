using UnityEngine;
using System.Collections;

public class WorldCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 camPos = Camera.main.transform.position;
        transform.Translate(-camPos.x, -camPos.y, -camPos.z);
        transform.rotation.Set(0, 0, 0, 0);
    }
}
