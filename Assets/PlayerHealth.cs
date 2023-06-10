using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour

{
    public int maxHealth = 60;
    public int currentHealth;

    public float invicibilityTimeAfterHit = 3f;
    public float invincibilityFlashDelay = 0.2f;
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
        if (!isInvicible)
        {
            currentHealth -= damage;
            isInvicible = true;
            StartCoroutine(InvincibilityFlash());
            StartCoroutine(HandleInvincibilityDelay());
        }

    }

    public IEnumerator InvincibilityFlash()
    {
        while (isInvicible)
        {
            graphics.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(invincibilityFlashDelay);
            graphics.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(invincibilityFlashDelay);
        }

    }

    public IEnumerator HandleInvincibilityDelay()
    {
        yield return new WaitForSeconds(invicibilityTimeAfterHit);
        isInvicible = false;
    }


}
