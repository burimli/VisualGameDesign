// Camera movement
    // Variable Declaration
    public Transform cameraPosition;
    public Transform respawnPoint; 
    // Make empty game object, drag to where you want the camera to teleport, and then drag it into the checkpoint script
        // Inside the if statement of checkpoint
            Camera.main.transform.position = new Vector3(
                            cameraPosition.position.x,
                            cameraPosition.position.y,
                            Camera.main.transform.position.z
                        );
            player.transform.position = new Vector3(respawnPoint.position);


// Player death
    // Variable Declaration
    public GameObject player;
    public Transform respawnPoint; 
    // Make empty game object, drag to where you want the player to respawn, and then drag it into the enemy/hazard script
            // Inside the if statement of enemy/hazard
            player.transform.position = new Vector3(respawnPoint.position);


// Projectiles
    // In a projectile script:
        // Variable Declaration
        public float speed = 4f;
            // in the update
            transform.position += -transform.right * speed * Time.deltaTime;

            private void OnCollisionEnter2D(Collision2D collision) {
                Destroy(gameObject);
            }
    // Drag projectile script into projectile
    // Create new empty game object as child of player, drag it to where the projectile fires out of, and drag into launch offset
    // drag the projectile into projectile prefab 