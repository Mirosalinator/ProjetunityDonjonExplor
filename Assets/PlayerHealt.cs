using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour

{
    public int maxHealth = 60;
    public int currentHealth;

    public bool isInvicible = false;

    public SpriteRenderer graphics;
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDomage(int damage)
    {
        if(!isInvicible)
        {
            currentHealth -= damage;
        }
       
    }

    public IEnumerator InvincibilityFlash
    {
        get
        {
            while (isInvicible)
            {
                graphics.color = new Color(1f, 1f, 1f, 0f);
            }

        }
    }
}
