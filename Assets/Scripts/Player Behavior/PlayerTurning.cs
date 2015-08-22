using UnityEngine;
using System.Collections;

public class PlayerTurning : AbstractBehavior
{
    void FixedUpdate()
    {
        var angle = Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle * Mathf.Rad2Deg));
    }
}
