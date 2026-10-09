using UnityEngine;

public class projectilescript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 public float speed = 4f;
    void Start()
    {
        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += -transform.right * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Destroy(gameObject);
        if (collision.gameObject.CompareTag("Enemy")){
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Player")){
            player.transform.position = new Vector3(respawnPoint.position);
        }
    }
}

    // Drag projectile script into projectile
    // Create new empty game object as child of player, drag it to where the projectile fires out of, and drag into launch offset
    // drag the projectile into projectile prefab 
    // enemies must be tagged as "Enemy" and player must be tagged as "Player" for the projectile to destroy them