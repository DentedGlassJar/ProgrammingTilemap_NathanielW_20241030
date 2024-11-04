using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapScript : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase groundTile;
    int[,] mapArea = new int [25,25];



    // Start is called before the first frame update
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

    void DrawTilemap()
    {
        for (int y = 0; y < mapArea.GetLength(1); y++)
        {
            for (int x = 0; x < mapArea.GetLength(0); x++)
            {
                if (mapArea[x,y] == 0)
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
}
