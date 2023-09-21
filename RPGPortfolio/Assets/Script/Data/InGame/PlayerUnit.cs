using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : UnitData
{
    public Camera UnitCamera;

    // PC Test
    private void Awake()
    {
        UnitAnimator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        //// PC Test
        //if (Input.GetKey(KeyCode.UpArrow) ||
        //    Input.GetKey(KeyCode.DownArrow))
        //{
        //    Move();
        //}
        //else if(Input.GetKey(KeyCode.Space))
        //{
        //    Attack();
        //}
        //else
        //    Idle();
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

        if (!UnitAnimator.GetBool("Attack"))
            transform.Rotate(new Vector3(0, 0.3f, 0));
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
