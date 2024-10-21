using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator _animator;

    // _animator 세팅 
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        // animationVariable을 수정
        _animator.SetInteger("State", animationVariable);
        animationVariable++;
        if (animationVariable > 2)
        { 
            animationVariable = 0;
        }
    }
}
