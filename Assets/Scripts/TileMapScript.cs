using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapScript : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase playerTile;
    public TileBase wallTile;
    public TileBase doorTile;
    public TileBase chestTile;

    string mapOutput;
    

    
    // Start is called before the first frame update
    void Start()
    {
        GenerateMapString(15,10);
        //ConvertMapToTileMap(mapData);
        
    }

    // Returns a string of a generated map
    public string GenerateMapString(int width, int height)
    {
        mapOutput = ($"###############{Environment.NewLine}#XXXXOXXXXXXXX#{Environment.NewLine}#XXXXXXXXXXXXX#{Environment.NewLine}" +
            $"#XXXXXX$XXXXXX#{Environment.NewLine}#XXXXXXXXXXXXX#{Environment.NewLine}#XXXXXXXXXXOXX#{Environment.NewLine}#XXXXXXXX$XXXX#{Environment.NewLine}" +
            $"#XXXXXXXXXXXXX#{Environment.NewLine}#XXXXXXXXXXXXX#{Environment.NewLine}###############");
        return mapOutput;
    }

    // Converts the map string into a unity tilemap
    void ConvertMapToTileMap(string mapData)
    {
        mapOutput = mapData;
        for (int x = 0; x < 15; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                if (mapOutput == "#")
                {
                    tilemap.SetTile(new Vector3Int(), wallTile);
                }

                if (mapData == "X")
                {
                    tilemap.SetTile(new Vector3Int(), playerTile);
                }

                if (mapData == "$")
                {
                    tilemap.SetTile(new Vector3Int(), chestTile);
                }

                if (mapData == "O")
                {
                    tilemap.SetTile(new Vector3Int(), doorTile);
                }   
            }
            //return mapData;
        }

        /*if (x == 0)
        {
            tilemap.SetTile(new Vector3Int(x, y, 0), wallTile);
        }
        */
    }

    // Loads a pre-made map from a text assetq
    void LoadPremadeMap(string mapFilePath)
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

