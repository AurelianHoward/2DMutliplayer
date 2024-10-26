using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 movedirection = Vector2.zero;
    [SerializeField] float MoveSpeed = 700;
    private Rigidbody2D MyRigidBody;
    private void Awake()
    {
        MyRigidBody = GetComponent<Rigidbody2D>();
    }
    private void OnMove(InputValue value)
    {
       movedirection = value.Get<Vector2>();
    }

    void Walk()
    {
            MyRigidBody.linearVelocity = movedirection * MoveSpeed * Time.deltaTime;
            //MyRigidBody.linearVelocityX = movedirection.x * MoveSpeed * Time.deltaTimerue;
    }

    private void Update()
    {
        Walk();
    }
}


    
