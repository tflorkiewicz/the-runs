using UnityEngine;
using System.Collections;

public class TextureScroll : MonoBehaviour {

    public float scrollSpeed = 1.0f;

    void Start()
    {
        //_levelManager = (GameManager)GameObject.FindWithTag("GameController").GetComponent("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var r in this.GetComponentsInChildren<Renderer>())
        {
            var offset = 0.1f * Time.time * scrollSpeed;
            r.material.mainTextureOffset = new Vector2(-offset, 0);
        }
    }
}
