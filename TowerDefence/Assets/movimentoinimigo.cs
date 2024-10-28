pzjousing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;
    private int pathIndex = 0;

    private void Start()
    {
        target = gerenciadordeniveis.main.path[pathIndex];

    }

    private void Update()
    {
        if (Vector2.Distance(target.position, transform.position)<= 0.1f) 
        {
            pathIndex++;
            

            if (pathIndex >= gerenciadordeniveis.main.path.Length)
            {
                Destroy(gameObject);
                return;
            }else
            {
                target = gerenciadordeniveis.main.path[pathIndex];
            }
        }    
    }
    private void FixedUpdate()
    {
     Vector2 direction = (target.position - transform.position).normalized;   
     rb.velocity = direction * moveSpeed;
    }
}
