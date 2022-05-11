using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class GameController : MonoBehaviour
{
    
    public float Speed = 5f;

    public float JumpForce = 300f;

   
    private bool _isGrounded;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
       
        JumpLogic();

        MovementLogic();

    }
  
 
      

        private void MovementLogic()
    {


        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveVertical, 0.0f);


        transform.Translate(movement * Speed * Time.fixedDeltaTime);
    }

    private void JumpLogic()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (_isGrounded)
            {
                
                _rb.AddForce(Vector2.up * JumpForce);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }

    void OnCollisionExit(Collision collision)
    {
        IsGroundedUpate(collision, false);
    }

    private void IsGroundedUpate(Collision collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            _isGrounded = value;
        }
    }
}