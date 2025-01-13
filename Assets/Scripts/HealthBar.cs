using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;
    private float maxHealth = 100;
    
    void Start()
    {
        EventManager<HealthEventPayload>.RegisterEvent(EventKey.UPDATE_HEALTH, UpdateHealth);
    }

    private void UpdateHealth(HealthEventPayload payload)
    {
        healthSlider.value = payload.Health / maxHealth;
        Debug.Log($"the name value has been called {payload.Name}");
    }

    private void OnDestroy()
    {
        EventManager<HealthEventPayload>.UnregisterEvent(EventKey.UPDATE_HEALTH, UpdateHealth);
    }
}
