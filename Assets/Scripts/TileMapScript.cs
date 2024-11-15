using UnityEngine;
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

    bool isMapPremade = false;


    // Start is called before the first frame update
    void Start()
    {
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
            for(int y = 0; y < height; y++)
            {
                mapOutput[7, 4] = playerStr;

                if (x == 0 || y == 0 || x == 14 || y == 9)
                {
                    mapString[x, y] = wallStr;
                    mapOutput[x, y] += mapString[x, y];
                }
                else if (x > 0 || y > 0 || x < 14 || y < 9)
                {
                    if(x == 1 && y == 1)
                    {
                        if(Random.Range(0,2) == 0)
                        {
                            mapString[x, y] = chestStr;
                            mapOutput[x, y] += mapString[x, y];
                        }
                        else
                        {
                            continue;
                        }
                    }
                    
                    if(x == 1 && y == 8)
                    {
                        if (Random.Range(0, 2) == 0)
                        {
                            mapString[x, y] = chestStr;
                            mapOutput[x, y] += mapString[x, y];
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if(x == 13 && y == 1)
                    {
                        if (Random.Range(0, 2) == 0)
                        {
                            mapString[x, y] = chestStr;
                            mapOutput[x, y] += mapString[x, y];
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (x == 13 && y == 8)
                    {
                        if (Random.Range(0, 2) == 0)
                        {
                            mapString[x, y] = chestStr;
                            mapOutput[x, y] += mapString[x, y];
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                /* I want there to be a max. of 2 chests in the corners of the map.
                 * I want to check and see if there is 5 wall tiles around the tile that the chest will spawn in
                 * If there is, I want to check if there is already 2 chests in the map, if there isn't, I want there to be a random spawn chance between 1/2 for a chest to spawn.
                 * If there's already two chests, I want the loop to break.
                */

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

