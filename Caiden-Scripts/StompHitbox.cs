using UnityEngine;

public class StompHitbox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Enemy enemy = GetComponentInParent<Enemy>();

            if (enemy != null)
            {
                enemy.Defeat();
            }
        }
    }
}