using UnityEngine;
using System.Collections;

public class PlayerMove : AbstractBehavior
{
    public float speed;

    void FixedUpdate()
    {
        var moveX = Input.GetAxis("Horizontal");
        var moveY = Input.GetAxis("Vertical");

        var impulse = new Vector2(moveX, moveY);

        transform.position += (Vector3)impulse;
    }
}
