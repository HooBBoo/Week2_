using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator _animator;

    // _animator ¼¼ÆÃ 
    void Awake()
    {
        _animator = GetComponent<Animator>();
        _animator.SetInteger("State", 0);
    }

    void OnMouseDown()
    {
        animationVariable = (animationVariable + 1) % 3;

        _animator.SetInteger("State", animationVariable);
    }

    //void OnMouseDown()
    //{
    //    switch (animationVariable)
    //    {
    //        case 0:
    //            animationVariable = 1;
    //            break;
    //        case 1:
    //            animationVariable = 2;
    //            break;
    //        case 2:
    //            animationVariable = 0;
    //            break;
    //    }
    //}
}
