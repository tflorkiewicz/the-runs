using UnityEngine;
using System.Collections;

public class HealthBars : MonoBehaviour {

    public float barDisplayEnergy; //current progress
    public float barDisplayFitness;
    public Vector2 pos;
    public Vector2 size;
    public Texture2D emptyTex;
    public Texture2D fullTex;

    private GameManager _gameManager;

    void Start()
    {
        pos = new Vector2(20, 40);
        size = new Vector2(200, 20);
        _gameManager = (GameManager)Camera.main.GetComponent("GameManager");
    }

    void OnGUI()
    {
        //draw the background:
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));

        GUI.TextArea(new Rect(0, 0, size.x, size.y), "Energy");
        GUI.Box(new Rect(50, 0, size.x, size.y), emptyTex);
        
        //draw the filled-in part:
        GUI.BeginGroup(new Rect(50, 0, size.x * barDisplayEnergy, size.y));
            GUI.Box(new Rect(0, 0, size.x, size.y), fullTex);
        GUI.EndGroup();
        GUI.EndGroup();


        //draw the background:
        GUI.BeginGroup(new Rect(pos.x, pos.y*2, size.x, size.y));

        GUI.TextArea(new Rect(0, 0, size.x, size.y*2), "Fitness");
        GUI.Box(new Rect(50, 0, size.x, size.y*2), emptyTex);

        //draw the filled-in part:
        GUI.BeginGroup(new Rect(50, 0, size.x * barDisplayFitness, size.y));
            GUI.Box(new Rect(0, 0, size.x, size.y*2), fullTex);
        GUI.EndGroup();
        GUI.EndGroup();
    }


    void Update()
    {
        barDisplayEnergy = _gameManager.Energy / 100f;
        barDisplayFitness = _gameManager.Fitness / 100f;
    }
}
