using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapScript : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase playerTile;
    public TileBase wallTile;
    public TileBase doorTile;
    public TileBase chestTile;
    int[,] mapArea = new int [22,22];



    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        
    }

    // Returns a string of a generated map
    void GenerateMapString()
    {

    }

    // Converts the map string into a unity tilemap
    void ConvertMapToTileMap()
    {

    }

    // 
    void LoadPremadeMap()
    {

    }


}



// ---------------------------------------------------------------------------------------------------

/* void DrawTilemap()
{
    for (int y = 0; y < mapArea.GetLength(1); y++)
    {
        for (int x = 0; x < mapArea.GetLength(0); x++)
        {
            if (mapArea[x, y] == 0)
            {
                tilemap.SetTile(new Vector3Int(x, y, 0), null);
            }
            else
            {
                tilemap.SetTile(new Vector3Int(x, y, 0), groundTile);
            }
        }
    }
}

    void Start()
    {
        for (int y = 0; y < mapArea.GetLength(1); y++)
        {
            for (int x = 0; x < mapArea.GetLength(0); x++)
            {
                mapArea[x,y] = Random.Range(0, 2);   
            }
        }
        DrawTilemap();
    }
*/

