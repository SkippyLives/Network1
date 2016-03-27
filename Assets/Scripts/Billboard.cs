using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Billboard : NetworkBehaviour {

    public GameObject player;

	// Update is called once per frame
	void Update () {

        transform.LookAt(player.GetComponentInChildren<Camera>().transform); // Camera.main.transform);
        //GetComponentInParent<Camera>().transform
	}
}
