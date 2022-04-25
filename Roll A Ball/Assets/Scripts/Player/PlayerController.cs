using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody rb;

    private float moveHorizontal;
    private float moveVertical;
    private Vector3 dir = Vector3.zero;

    private void Start()
    {
        AssignVariables();
    }

    private void FixedUpdate()
    {
        if (GameManager.Instance.state != GameManager.GameState.GAME) { return; }

        Move();
    }
    private void Update()
    {
        HandleInput();
    }

    private void Move()
    {
        rb.AddForce(dir * speed, ForceMode.Force);
    }
    private void HandleInput()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        dir = new Vector3(moveHorizontal, 0, moveVertical);
    }

    private void AssignVariables()
    {
        rb = GetComponent<Rigidbody>();
    }
}
