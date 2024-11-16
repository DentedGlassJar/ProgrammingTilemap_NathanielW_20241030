﻿using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapScript : MonoBehaviour
{       
    // The sprites used for the mapTiles
    public Tilemap tilemap;
    public TileBase playerTile;
    public TileBase wallTile;
    public TileBase doorTile;
    public TileBase chestTile;

    // The size for the map
    int width = 15;
    int height = 10;

    // Bool for is that specific tile is walkable or not.
    bool isTileWalkable;

    // The characters used that represents different mapTiles
    string wallStr = "#";
    string doorStr = "O";
    string chestStr = "$";
    string playerStr = "X";

    public string[,] mapOutput;

    //string pathToMapFile = $"{Application.dataPath}/textFile/textFileMap.txt";

    // A bool that turns true if a chest has been created in a map
    bool isChestCreated;

    // A int that increases by one for every created door
    int numOfDoors;

    // A bool that returns true if two doors have been created
    bool isDoorsCreated;

    bool isMapPremade = false;


    // Start is called before the first frame update
    void Start()
    {
        isChestCreated = false;

        numOfDoors = 0;
        isDoorsCreated = false;

        //LoadPremadeMap(File.ReadAllLines(pathToMapFile);
        GenerateMapString();

        ConvertMapToTileMap();
        
    }

    private void Update()
    {
        PlayerMovement();
    }

    // Returns a string of a generated map
    public void GenerateMapString()
    {

        string[,] mapString = new string[width,height];
        mapOutput = new string[width,height];
        for(int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                mapOutput[7, 4] = playerStr;

                // Generational Rule for the walls
                if (x == 0 || y == 0 || x == 14 || y == 9)
                {
                    mapString[x, y] = wallStr;
                    mapOutput[x, y] += mapString[x, y];
                }

                // Procedural Generation Rule for the chests
                else if (x == 1 || y == 1 || x == 13 || y == 8)
                {
                    if (x == 1 && y == 1)
                    {
                        if (Random.Range(0, 3) == 0)
                        {
                            mapString[x, y] = chestStr;
                            mapOutput[x, y] += mapString[x, y];
                            isChestCreated = true;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    else if (x == 1 && y == 8)
                    {
                        if (Random.Range(0, 3) == 0)
                        {
                            if (isChestCreated == false)
                            {
                                mapString[x, y] = chestStr;
                                mapOutput[x, y] += mapString[x, y];
                                isChestCreated = true;
                            }
                            else
                            {
                                mapString[x, y] = null;
                                mapOutput[x, y] += mapString[x, y];
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                    else if (x == 13 && y == 1)
                    {
                        if (Random.Range(0, 3) == 0)
                        {
                            if (isChestCreated == false)
                            {
                                mapString[x, y] = chestStr;
                                mapOutput[x, y] += mapString[x, y];
                                isChestCreated = true;
                            }
                            else
                            {
                                mapString[x, y] = null;
                                mapOutput[x, y] += mapString[x, y];
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                    else if (x == 13 && y == 8)
                    {
                        if (isChestCreated == false)
                        {
                            mapString[x, y] = chestStr;
                            mapOutput[x, y] += mapString[x, y];
                            isChestCreated = true;
                            continue;
                        }
                    }

                    // Procedural Generation Rule for the doors
                    if (Random.Range(0, 6) == 0)
                    {
                        if (numOfDoors == 2)
                        {
                            isDoorsCreated = true;
                        }

                        if (isDoorsCreated == true)
                        {
                            continue;
                        }

                        if (mapOutput[x, y] == chestStr)
                        {
                            continue;
                        }
                        else
                        {
                            mapString[x, y] = doorStr;
                            mapOutput[x, y] += mapString[x, y];
                            numOfDoors++;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        } 
    }

    // Converts the map string into a unity tilemap
    void ConvertMapToTileMap()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {

                if (mapOutput[x, y] == wallStr)
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), wallTile);
                    isTileWalkable = false;
                }

                if (mapOutput[x, y]  == playerStr)
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), playerTile);
                    isTileWalkable = true;
                }

                if (mapOutput[x, y] == chestStr)
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), chestTile);
                    isTileWalkable = false;
                }

                if (mapOutput[x, y] == doorStr)
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), doorTile);
                    isTileWalkable = true;
                }
            }
        }
    }

    // Loads a pre-made map from a text assets
    void LoadPremadeMap(string mapFilePath)
    {    
    }

    void PlayerMovement()
    {
    }
}



// ---------------------------------------------------------------------------------------------------

