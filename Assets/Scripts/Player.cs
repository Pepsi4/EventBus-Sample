using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float currentHealth = 100;
    public Action<float> HealthChanged { get; }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentHealth -= 10;

            if (currentHealth < 0)
                currentHealth = 0;

            EventManager<HealthEventPayload>.TriggerEvent(EventKey.UPDATE_HEALTH, new HealthEventPayload()
            {
                Health = currentHealth,
                Name = "John"
            });
        }
    }
}
