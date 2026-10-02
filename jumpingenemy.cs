using UnityEngine;

public class jumpingenemy : MonoBehaviour
{
    private float jumpTimer = 0;
    [SerializeField] private float jumpInterval = 2f;
    [SerializeField] private float jumpingPower = 350;
    private Rigidbody2D jumpingEnemy;

    void Start()
    {
        jumpingEnemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        jumpTimer += Time.deltaTime;

        if (jumpTimer >= jumpInterval){
            jumpingEnemy.linearVelocity = new Vector2(jumpingEnemy.linearVelocity.x,jumpingPower);
            jumpTimer = 0;
        }
    }
}
