using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class InputHandler : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int tilePos = TowerHandler.Instance.TowerGrid.LocalToCell(mousePos);
            
            if (TowerHandler.Instance.TowerGrid.HasTile(tilePos))
            {
                // Here we should toggle tower stats?
                if (TowerHandler.Instance.HasTower(tilePos))
                {
                    print("Has tower.");
                } else
                {
                    print(TowerHandler.Instance.TowerGrid.GetInstantiatedObject(tilePos));
                    // TODO: Spawn random tower? Determine Player based on player input?
                    TowerHandler.Instance.PlaceTower(TowerHandler.Instance.BlueTower, tilePos);
                }
                
            }
        }
    }
}
