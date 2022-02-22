using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float FallingTime;
    private TargetJoint2D _targetJoint2D;
    private BoxCollider2D _boxCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        _targetJoint2D = GetComponent<TargetJoint2D>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("Falling", FallingTime);
        }

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 6)
        {
            Destroy(gameObject);
        }
    }

    void Falling()
    {
        _targetJoint2D.enabled = false;
        _boxCollider2D.isTrigger = true;
    }
}
