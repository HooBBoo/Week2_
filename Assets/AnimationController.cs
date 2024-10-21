using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator _animator;

    // _animator ���� 
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        // animationVariable�� ����
        _animator.SetInteger("State", animationVariable);
        animationVariable++;
        if (animationVariable > 2)
        { 
            animationVariable = 0;
        }
    }
}
