using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private GameManager _gameManager;

    private int jumpsInProgress = 0;
    private float lastJumpTime = 0f;


	// Use this for initialization
	void Start () {
        _gameManager = (GameManager)Camera.main.GetComponent("GameManager");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) 
            && Time.time > (lastJumpTime + 0.25f)
            && jumpsInProgress < _gameManager.JumpsAllowed)
        {
            this.rigidbody.AddForce(0f, _gameManager.JumpPower, 0f, ForceMode.Acceleration);
            _gameManager.Jump();
            
            jumpsInProgress += 1;
            lastJumpTime = Time.time;
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            jumpsInProgress = 0;
        }
    }
}
