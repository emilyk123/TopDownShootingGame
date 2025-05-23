using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Uses the new unity input system
    public InputActionAsset InputActions;
    private InputAction movementInput;
    private Vector2 direction;
    private float moveSpeed = 5f;

    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }

    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    private void Awake()
    {
        movementInput = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
        // Gets the direction of the input from the WASD keys
        direction = movementInput.ReadValue<Vector2>();
        // Changes the current position of the player
        transform.position = new Vector3(transform.position.x + direction.x * moveSpeed * Time.deltaTime,
                                         transform.position.y + direction.y * moveSpeed * Time.deltaTime,
                                         0);
    }
}
