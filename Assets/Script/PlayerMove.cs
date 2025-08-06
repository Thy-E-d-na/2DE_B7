using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private InputActionReference _jump;
    [SerializeField] private Rigidbody2D _rg;
    [SerializeField] private float _jumpForce;
    bool isGrounded;
    [SerializeField] private Animator _anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }
    private void Update()
    {
        if(_jump.action.triggered && isGrounded)
        {
            Debug.Log("JUMP");
            _rg.AddForce(Vector2.up * _jumpForce,ForceMode2D.Impulse);
            _anim.SetBool("IsJump",true);
            isGrounded = false;
        }
    }
}
