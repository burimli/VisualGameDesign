using UnityEngine;

public class walkingenemy : MonoBehaviour
{
    public GameObject pointA; // left bound of the enemy's movement
    public GameObject pointB; // right bound of the enemy's movement
    private Rigidbody2D walkingEnemy;
    private Transform currentPoint;
    float moveSpeed=30;


    void Start()
    {
        walkingEnemy = GetComponent<Rigidbody2D>();
        currentPoint = pointA.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointA.transform){
            walkingEnemy.linearVelocity = new Vector2(-moveSpeed, 0);
        }
        else if (currentPoint == pointB.transform){
            walkingEnemy.linearVelocity = new Vector2(moveSpeed, 0);
        }

        if (transform.position.x <= pointA.transform.position.x + 1.1f){
            currentPoint = pointB.transform;
        }
        if (transform.position.x >= pointB.transform.position.x - 1.1f){
            currentPoint = pointA.transform;
        }
    }
}
