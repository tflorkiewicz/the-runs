using UnityEngine;
using System.Collections;

public class ItemMove : MonoBehaviour {

    public float Speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var position = this.transform.position;
        position.x -= Speed * Time.deltaTime;
        this.transform.position = position;
	}
}
