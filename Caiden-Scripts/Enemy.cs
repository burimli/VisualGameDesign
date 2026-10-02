using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with enemy!");
        }
    }

    public void Defeat()
    {
        Debug.Log("Enemy defeated!");
        Destroy(gameObject);
    }
}