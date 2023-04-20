using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtyThing : MonoBehaviour
{
    [Header("Events")]
    public GameEvent onPlayerHealthUpdate;

    public int damageAmount;

    private void Awake()
    {
        damageAmount = 20;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            onPlayerHealthUpdate.Raise(this, -damageAmount);
        }
    }
}
