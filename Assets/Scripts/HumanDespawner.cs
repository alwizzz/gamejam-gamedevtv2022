using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanDespawner : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D humanCollider)
    {
        var human = humanCollider.gameObject.GetComponent<Human>();
        if (human.IsDespawnable())
        {
            human.GoingToDespawn();
            human.Die();
        }
    }
}
