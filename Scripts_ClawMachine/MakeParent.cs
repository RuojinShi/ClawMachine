using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MakeParent : MonoBehaviour
{

    public GameObject parent;

    void Start()
	{
       
    }

	
    void OnTriggerEnter(Collider col){

       // Debug.Log("any collision");

       if (col.gameObject.tag == "claw")
		{
            Debug.Log("claw collide");

            this.transform.parent = parent.transform;

        }
        else if (col.gameObject.tag == "ball" )
        {
            Debug.Log("ball collision");
            this.transform.parent = null;
        }
       
	}
}
