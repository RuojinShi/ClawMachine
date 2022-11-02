using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class EnableGravity : MonoBehaviour
{
    public Collider coll;


    void Start()
    {
        coll = GetComponent<Collider>();
        coll.isTrigger = true;
    }


    void OnTriggerEnter(Collider col)
    {

        

       
            
            if (col.gameObject.tag == "toy")
            {
            Debug.Log("ball any collide");
             if (col.transform.parent != null && col.attachedRigidbody)
                {
                    Debug.Log("toy collide ball when child");
                    col.attachedRigidbody.useGravity = true;
                }


            }

           
               
           

        
    

    }
}
