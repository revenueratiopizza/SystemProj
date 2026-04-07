using UnityEngine;
using UnityEngine.InputSystem;
public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10.0f;
    public GameObject bullet;
    public Vector2 bulletMove;
    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
    }
}