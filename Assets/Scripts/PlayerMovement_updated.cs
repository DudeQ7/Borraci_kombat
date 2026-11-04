using UnityEngine;
using UnityEngine.InputSystem;
public class NewMonoBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpHeight = 2f;
    [SerializeField] private float gravity = -9.81f;
    private CharacterController controller;
    private Vector3 moveInput;
    private Vector3 velocity;
    void Start()
    {
        controller = GetComponent<CharacterController>();
     }
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
    //dokoncz 5:20 - https://www.youtube.com/watch?v=qEtLamo_-_g 
    void Update()
    {
        
    }

}

