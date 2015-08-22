using UnityEngine;
using System.Collections;

public abstract class AbstractBehavior : MonoBehaviour 
{
    protected Rigidbody2D _rb2d;

    protected void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }
}
