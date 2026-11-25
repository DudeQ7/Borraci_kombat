using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public InputActionReference moveAction, punchAction, jumpAction;
    private float moveX,X,Y,Z;
    public float speed = 5f,jumpForce =10f;
    private bool isJumping, isPunching,isGrounded = false;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }
    void OnCollisionStay(Collision collison)
    {
        if (collison.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        
    }
    void OnCollisionExit(Collision collison)
    {
        if (collison.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    void OnEnable()
    {
        moveAction.action.Enable();
        punchAction.action.Enable();
        jumpAction.action.Enable();
    }
    void OnDisable()
    {
        moveAction.action.Disable();
        punchAction.action.Disable();
        jumpAction.action.Disable();
    }
    void Update()
    {
        moveX = moveAction.action.ReadValue<float>();
        isJumping = jumpAction.action.WasPressedThisFrame();
        isPunching = punchAction.action.WasPressedThisFrame();
   
    }
    void FixedUpdate()
    {
        X = moveX * speed;
        Y = rb.linearVelocity.y;
        Z = rb.linearVelocity.z;
        if ((isJumping)&&(isGrounded))
        {
            Y = jumpForce;
        }
        rb.linearVelocity = new Vector3(X, Y, Z);
        
    }
}

