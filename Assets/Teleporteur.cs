using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporteur : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Menus"); 
        }
    }
}
