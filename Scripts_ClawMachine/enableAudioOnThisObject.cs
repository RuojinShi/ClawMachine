using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableAudioOnThisObject : MonoBehaviour
{

    // Use this for initialization
    public bool alreadyPlayed = false;

    void Start()
	{

	}

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "claw"&& !alreadyPlayed)
		{
            Debug.Log("trigger audio");
            //below enables entire audio source component
            GetComponent<AudioSource>().enabled = true;
			//below  causes audio to play
			GetComponent<AudioSource>().Play();
            alreadyPlayed = true;

        }
	}
}