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