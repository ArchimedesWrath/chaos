using UnityEngine.Tilemaps;
using UnityEngine;

public class TilemapHandler : Singleton<TilemapHandler>
{
    public Tilemap tilemap;
    public TileBase stile;

    private Vector3Int pos;
    private Vector3Int size;

    private void Start()
    {

        pos = tilemap.cellBounds.position;
        size = tilemap.cellBounds.size;

        //print("pos: " + pos);
        //print("size: " + size);

        
    }
}
