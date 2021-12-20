using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] protected float damage;

    protected void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.tag == "Player")
            collison.GetComponent<Health>().TakeDamage(damage);
    }
}