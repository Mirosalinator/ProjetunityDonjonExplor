
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            Debug.Log(GameObject.FindGameObjectWithTag("PlayerSpawn").transform.position);
            collision.transform.position = GameObject.FindGameObjectWithTag("PlayerSpawn").transform.position;
        }
    }
}
