using UnityEngine;
using UnityEngine.InputSystem;

public class ZombieMovement : MonoBehaviour
{
    public float speed = 4f;
    public Vector2 movement;
    public GameObject target;
    public GameObject bulletThatDestroysZombie;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Nick might not always be in the scene
        // so we need to figure out where he is first
        target = GameObject.FindGameObjectWithTag("Player");
        // https://docs.unity3d.com/6000.4/Documentation/Manual/Tags.html
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movement * speed * Time.deltaTime;
        // Same thing as PlayerMovement but now it's facing towards the target
        Vector2 direction = target.transform.position - transform.position; 
        // Target has to be the player at all times
        transform.up = direction;
        transform.position += (Vector3)direction.normalized * speed * Time.deltaTime;
        // I want the normalized vector because
        //
        // I'm gonna be honest I heard "normalized" in a video once and I thought it sounded really cool. Like that's literally all I'm working off of
        // https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Vector3-normalized.html

        // If this object (the zombie) "collides" with bulletThatDestroysZombie(if their X position is greater than the X position of the bullet - 10 or kess than the X position of the bullet + 10)
        // Then destroy the zombie
    }
}
