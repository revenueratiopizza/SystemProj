using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movement * speed * Time.deltaTime;

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 direction = mousePos - (Vector2)transform.position;
        transform.up = direction;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started) // https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/Interactions.html?q=context.phase
        {
            transform.Translate(Vector3.up * -0.25f); // https://docs.unity3d.com/ScriptReference/Transform.Translate.html
            Debug.Log("Attack: " + context.phase);
        }
    }
    // https://www.youtube.com/watch?v=S7XFIB0mbEQ
}
