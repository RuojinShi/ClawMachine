using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fluctuateNormalTiling : MonoBehaviour {
    public float scrollSpeed = 0.5F;
    public Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        float scaleX = Mathf.Cos(Time.time) * .5F + 1F;
        float scaleY = Mathf.Sin(Time.time) * .75F + 1F;
        rend.material.SetTextureScale("_MainTex", new Vector2(scaleX, scaleY));
    }
}


