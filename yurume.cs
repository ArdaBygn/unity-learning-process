using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yurume : MonoBehaviour
{
    Rigidbody2D rb;
    public float JumpSpeed=1f,jumpFrequncy=1f,nextJump;
    Animator anim;
    public float MoveSpeed=1f;
    bool facingRight=true;
    public Transform GroundPosition;
    public float GrounRadius;
    public LayerMask GroundLayer;
    bool isGrounded=false;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        onGroundCheck();
        HorizontalMove();
        if(rb.velocity.x<0 && facingRight)
        {
           flipFace();
        }
        else if(rb.velocity.x>0 && !facingRight)
        {
           flipFace();
        }
        if(Input.GetAxis("Vertical")>0 && isGrounded && (nextJump<Time.timeSinceLevelLoad))
        {
            nextJump=Time.timeSinceLevelLoad+jumpFrequncy;
           Jump();
        }
    }
    void HorizontalMove()
    {
        rb.velocity=new Vector2(Input.GetAxis("Horizontal")*MoveSpeed,rb.velocity.y);
        anim.SetFloat("PlayerSpeed", Mathf.Abs(rb.velocity.x));
    }
    void flipFace()
    {
        facingRight=!facingRight;
        Vector3 transLocale=transform.localScale;
        transLocale.x*=-1;
        transform.localScale=transLocale;
    }
    void Jump()
    {
        rb.AddForce(new Vector2(0f,JumpSpeed));
    }
    void onGroundCheck()
    {
        isGrounded=Physics2D.OverlapCircle(GroundPosition.position,GrounRadius,GroundLayer);
        anim.SetBool("Jump",isGrounded);
    }
}
