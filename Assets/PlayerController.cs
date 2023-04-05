using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed = 1.0f;
    private Vector2 _movement = Vector2.zero;
    private Rigidbody2D _rigidbody;

    public PlayerManager PlayerManager { get; private set; }
    private GameControls Controls => GameManager.controls;
    private Vector2 MovementInput => Controls.PlayerControls.Movement.ReadValue<Vector2>().normalized;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        PlayerManager = GetComponent<PlayerManager>();
        Controls.PlayerControls.Enable();
    }

    private void FixedUpdate()
    {
        ManageMovement();
        ManageVelocity();
    }

    private void ManageMovement()
    {
        _movement.x = MovementInput.x;
        _movement.y = MovementInput.y;
        _movement *= PlayerSpeed;

        Debug.Log($"{MovementInput}, {_movement}, {_rigidbody.velocity}");
    }

    private void ManageVelocity()
    {
        _rigidbody.velocity = _movement;
    }
}
