using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : UnitData
{
    // PC Test
    private void Awake()
    {
        UnitAnimator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        // PC Test
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Move();
        }

        if(Input.GetKey(KeyCode.Space)) 
        {
            Attack();
        }
    }

    public override void Attack()
    {
        UnitAnimator.SetBool("Attack", true);
    }

    public override void Death()
    {
        UnitAnimator.SetBool("Death", true);
    }

    public override void Idle()
    {
        UnitAnimator.SetBool("Attack", false);
        UnitAnimator.SetBool("Move", false);
        UnitAnimator.SetBool("Death", false);
    }

    public override void Move()
    {
        UnitAnimator.SetBool("Move", true);
    }

    void UnitControl()
    {

    }

    void UnitMoveControl()
    {

    }

    void UnitSkillControl()
    {

    }
}
