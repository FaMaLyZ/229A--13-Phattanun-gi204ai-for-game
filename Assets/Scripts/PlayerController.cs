using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private InputAction moveAction;
    private float horizontalInput;
    private float verticalInput;
    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = moveAction.ReadValue<Vector2>().x;
        verticalInput = moveAction.ReadValue<Vector2>().y;

        transform.Translate(horizontalInput * moveSpeed * Time.deltaTime * Vector3.left);
        transform.Translate(verticalInput * moveSpeed * Time.deltaTime * Vector3.up);
    }
}
