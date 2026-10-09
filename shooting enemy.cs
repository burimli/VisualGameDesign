using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform player;
    public float projectileSpeed = 5f;
    public float shootInterval = 2f;   
    public Transform launchOffset;
        void Start() {
            InvokeRepeating(nameof(Shoot), 1f, shootInterval);
        }
        private void Shoot() {
            GameObject projectile = Instantiate(
                projectilePrefab,

                launchOffset.position,
                launchOffset.rotation
            );

            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
         }

    // Update is called once per frame
    void Update()
    {
        
    }
}
