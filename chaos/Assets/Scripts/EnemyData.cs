using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "ScriptableObjects/Enemy", order = 1)]
public class EnemyData : ScriptableObject
{
    public int id;
    public Sprite img;
    public string enemyName;
    public float health;
    public float speed;
}
