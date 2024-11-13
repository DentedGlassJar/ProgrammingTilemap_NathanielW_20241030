using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.IO;

public class TileMapScript : MonoBehaviour
{
    //https://learn.microsoft.com/en-us/dotnet/standard/base-types/stringbuilder

    public Tilemap tilemap;
    public TileBase playerTile;
    public TileBase wallTile;
    public TileBase doorTile;
    public TileBase chestTile;

    char playerChar = 'X';
    char wallChar = '#';
    char doorChar = 'O';
    char chestChar = '$';

    string mapOutput;

    //string pathToMapFile = $"{Application.dataPath}/textFile/textFileMap.txt";

    bool isMapPremade = false;



    // Start is called before the first frame update
    void Start()
    {
        //LoadPremadeMap(File.ReadAllLines(pathToMapFile);
        string mapData = GenerateMapString(15, 10);

        Debug.Log($"{mapData}");

        ConvertMapToTileMap(mapData);
        
    }

    // Returns a string of a generated map
    public string GenerateMapString(int width, int height)
    {
        char[,] mapOutput = new char[width,height];
        for (int x = 0; x < mapOutput.GetLength(0); x++)
        {
            for (int y = 0; y < mapOutput.GetLength(1); y++)
            {
                if (x == 0 && y == height - 1 || x == width - 1 && y == 0)
                {
                    mapOutput[x, y] = wallChar;
                }
            }
        }

        return mapOutput.ToString();
        
        /* mapOutput = ($"###############{Environment.NewLine}#XXXXOXXXXXXXX#{Environment.NewLine}#XXXXXXXXXXXXX#{Environment.NewLine}" +
            $"#XXXXXX$XXXXXX#{Environment.NewLine}#XXXXXXXXXXXXX#{Environment.NewLine}#XXXXXXXXXXOXX#{Environment.NewLine}#XXXXXXXX$XXXX#{Environment.NewLine}" +
            $"#XXXXXXXXXXXXX#{Environment.NewLine}#XXXXXXXXXXXXX#{Environment.NewLine}###############");
        return mapOutput; */
    }

    // Converts the map string into a unity tilemap
    void ConvertMapToTileMap(string mapData)
    {
        
        /*for (int x = 0; x < char.Parse(mapData); x++)
        {
            for (int y = 0; y < char.Parse(mapData); y++)
            {
                Debug.Log($"MapData is {char.Parse(mapData)}");

                if (mapData == "#")
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), wallTile);
                }

                if (mapData == "X")
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), playerTile);
                }

                if (mapData == "$")
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), chestTile);
                }

                if (mapData == "O")
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), doorTile);
                }   
            }
            //return mapData;
        }

        if (x == 0)
        {
            tilemap.SetTile(new Vector3Int(x, y, 0), wallTile);
        }
        */
    }

    // Loads a pre-made map from a text assets
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

