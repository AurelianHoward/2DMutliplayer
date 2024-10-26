using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControls : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D MyRigidBody;
    private Vector2 playerVelocity;
    [SerializeField]
    private float playerSpeed = 2.0f;

    private Vector2 movementinput = Vector2.zero;

    private void Start()
    {
        MyRigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementinput = context.ReadValue<Vector2>();
    }

    void Update()
    {
        MyRigidBody.linearVelocity = playerVelocity * playerSpeed * Time.deltaTime;

    }
}
