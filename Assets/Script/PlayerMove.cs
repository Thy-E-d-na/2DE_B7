using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private InputActionReference _jump;
    [SerializeField] private InputActionReference _move;
    [SerializeField] private Rigidbody2D _rg;
    [SerializeField] private float _jumpForce;
    bool isGrounded;
    [SerializeField] private Animator _anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
        _anim.SetBool("IsJump", false);
       
    }
    private void Update()
    {
        var x =_rg.transform.position;
        if(_jump.action.triggered && isGrounded)
        {
            _rg.AddForce(Vector2.up * _jumpForce,ForceMode2D.Impulse);
            _anim.SetBool("IsJump",x.y != 0);  
            isGrounded = false;
        }
       
    }
}
