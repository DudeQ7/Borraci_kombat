using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public InputActionReference  moveAction, punchAction,jumpAction;

    private void OnEnable()
    {
        inputAction.action.Enable();
        punchAction.action.Enable();
        jumpAction.action.Enable();
    }
    private void OnDisable()
    {
        inputAction.action.Disable();
        punchAction.action.Disable();
        jumpAction.action.Disable();
    }
    private void Update()
    {
        private float moveX = moveAction.action.ReadValue<float>();
        private bool isJumping = jumpAction.action.WasPressedThisFrame();
        private bool isPunching = punchAction.action.WasPressedThisFrame();
    }
}

