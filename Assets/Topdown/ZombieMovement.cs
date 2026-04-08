using UnityEngine;
using UnityEngine.InputSystem;

public class ZombieMovement : MonoBehaviour
{
    public float speed = 4f;
    public Vector2 movement;
    public GameObject target;
    public GameObject[] bulletThatDestroysZombie;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Nick might not always be in the scene
        // so we need to figure out where he is first
        target = GameObject.FindGameObjectWithTag("Player");
        // https://docs.unity3d.com/6000.4/Documentation/Manual/Tags.html

        // Let's also do the same with the bullets in Update
        // For some reason I thought Start and Update were the same thing when writing this code
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movement * speed * Time.deltaTime;
        // Same thing as PlayerMovement but now it's facing towards the player
        Vector2 direction = target.transform.position - transform.position;
        // Target has to be the player at all times
        transform.up = direction;
        transform.position += (Vector3)direction.normalized * speed * Time.deltaTime;
        // I want the normalized vector because I heard "normalized" in a video once and I thought the term sounded slick
        // https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Vector3-normalized.html

        // https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
        // Thank you docs.unity3d.com for coming in clutch
        // I still don't know how to use arrays though

        bulletThatDestroysZombie = GameObject.FindGameObjectsWithTag("Bullet");
        foreach (GameObject bulletThatDestroysZombie in bulletThatDestroysZombie)
        {
            if (bulletThatDestroysZombie != null) // I should add a null here to make sure it doesn't return an error with no bullets
            {
                if (Vector2.Distance(transform.position, bulletThatDestroysZombie.transform.position) < 0.5f)
                    // Atp I'm just throwing stuff at the wall
                {
                    Destroy(gameObject);
                    // No strict collision checks because I don't remember if we learned this in class
                    // https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Vector3.Distance.html
                }
            }
        }
    }
}
