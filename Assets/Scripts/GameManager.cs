using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public float Energy = 50f;
    public float Fitness = 50f;
    public float DailyCalories = 1500f;

    public float JumpPower
    {
        get
        {
            return Fitness * 6f;
        }
    }

    public int JumpsAllowed
    {
        get
        {
            if (Fitness < 25f) return 1;
            else if (Fitness < 50f) return 2;
            else if (Fitness < 75f) return 3;
            else return 4;
        }
    }


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
        Energy -= 2f * Time.deltaTime;
        if (Energy <= 0f)
        {
            // end game
            Debug.Log("died");
        }
	}

    public void Jump()
    {
        Energy -= 1f;
    }
}
