using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData enemyData;
    public Transform target;

    private SpriteRenderer sr;
    private Rigidbody2D rb2d;
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = enemyData.img;
    }

    private void Update()
    {
        if (target) MoveTarget();
    }

    private void MoveTarget()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, enemyData.speed * Time.deltaTime);
    }
}
