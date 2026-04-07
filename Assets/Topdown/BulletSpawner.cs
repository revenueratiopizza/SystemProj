using UnityEngine;
using UnityEngine.InputSystem;
// https://www.youtube.com/watch?v=qrr4BGRcv3I
// https://www.youtube.com/watch?v=_4TRkQK7nNs
// https://www.youtube.com/watch?v=7qvuuQ1oCMk
public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started) // https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/Interactions.html?q=context.phase
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation); // https://www.youtube.com/watch?v=gq3uzsnvn10
        }
    }
}
