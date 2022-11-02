using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggerExample : MonoBehaviour
{
    public Animator _animator;

    public Animator humanAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.anyKeyDown)
    //    {
    //        _animator.SetTrigger("ExampleTrigger");
    //    }
        
    //}

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "human")

        {
            Debug.Log("animation collide");
            _animator.SetTrigger("anitrigger1");

            humanAnimator.SetTrigger("anitrigger2");

        }
       

    }
}
