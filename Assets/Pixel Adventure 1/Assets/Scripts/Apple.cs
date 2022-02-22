using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private CircleCollider2D _circleCollider;
    private SpriteRenderer _spriteRenderer;
    public GameObject collected;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _circleCollider = GetComponent<CircleCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            _spriteRenderer.enabled = false;
            _circleCollider.enabled = false;
            collected.SetActive(true);     
            GameController.instance.totalScore += score;            
            GameController.instance.UpdateScore();


            Destroy(gameObject, 0.3f);
        }
    }
}
