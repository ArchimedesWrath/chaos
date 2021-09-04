using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TowerHandler : Singleton<TowerHandler>
{
    public Dictionary<Vector3Int, Tower> Towers = new Dictionary<Vector3Int, Tower>();

    public Tilemap TowerGrid;

    public GameObject BlueTower;

    private Vector3Int pos;
    private Vector3Int size;

    private void Start()
    {

        pos = TowerGrid.cellBounds.position;
        size = TowerGrid.cellBounds.size;

        //print("pos: " + pos);
        //print("size: " + size);

    }


    public bool HasTower(Vector3Int pos)
    {
        return Towers.ContainsKey(pos);
    }

    public void PlaceTower(GameObject tower, Vector3Int pos)
    {
        Vector3 cellPos = TowerGrid.CellToLocal(pos);
        Vector3 towerPos = new Vector3(cellPos.x + 0.25f, cellPos.y + 0.25f, 0);
        GameObject newTower = Instantiate(tower, towerPos, Quaternion.identity);
        Tower towerScript = newTower.GetComponent<Tower>();
        Towers.Add(pos, towerScript);
    }
}
