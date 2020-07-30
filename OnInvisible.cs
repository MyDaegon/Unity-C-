using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInvisible : MonoBehaviour
{
    private Rigidbody2D EnemyRB;
    public float Velocidade;

    void Start() {
        EnemyRB = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        
        EnemyRB.velocity = new Vector2(Velocidade, 0);

    }
    void OnBecameInvisible() {
        
        GameController.Dest += 1;
        Destroy(gameObject);

    }
    
}
