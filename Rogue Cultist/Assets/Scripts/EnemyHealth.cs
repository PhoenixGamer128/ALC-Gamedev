using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float deathDelay;

    private Renderer renderer;
    private float blinkTime;
    private float blink;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        currentHealth = maxHealth;
        blinkTime = 30 * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if ((blink < blinkTime && blink > blinkTime * .7) || (blink < blinkTime * 0.5 && blink > blinkTime * 0.2))
        {
            renderer.material.color = Color.red;
        }
        else
        {
            renderer.material.color = Color.white;
        }
        blink -= 1;
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;
        //renderer.material.color = Color.red;
        //renderer.material.color = Color.white;


        if(currentHealth <= 0)
        {
            Debug.Log("Enemy Defeated");
            Destroy(gameObject,deathDelay);
        }
    }

    /*
    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    */
}
