using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporteur : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("menus"); // Remplacez "Menu" par le nom de votre scène de menu
        }
    }
}
