using UnityEngine;
public class EnnemyPatrol : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    public int damageOnCollision;

    public SpriteRenderer graphics;
    private Transform traget;
    private int destPoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        traget = waypoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = traget.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, traget.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length;
            traget = waypoints[destPoint];
            graphics.flipX = !graphics.flipX;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDomage(20);

        }
    }
}
