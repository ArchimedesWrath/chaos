using UnityEngine;

[CreateAssetMenu(fileName = "Tower", menuName = "ScriptableObjects/Tower", order = 2)]
public class TowerData : ScriptableObject
{
    public int id;
    public Sprite diagonal;
    public Sprite vertical;
    public Sprite horizontal;
    public string towerName;
    public int level;
    public float damage;
    public float speed;
    public float range;
}
