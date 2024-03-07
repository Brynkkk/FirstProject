using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private Animator m_Animator;
    void Start()
    {
       m_Animator = GetComponent<Animator>(); 
    }
    
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            m_Animator.SetTrigger("goAttack");
        }
    }
}
