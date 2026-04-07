using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10.0f;
    public GameObject bullet;
    public Vector2 bulletMove;
    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
        if (transform.position.x > 12f || transform.position.x < -12f || transform.position.y > 12f || transform.position.y < -12f) {
            Destroy(gameObject);
        }
    }
}