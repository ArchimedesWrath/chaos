using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public TowerData towerData;

    private Sprite sprite;

    public void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
        sprite = towerData.diagonal;
    }
}
