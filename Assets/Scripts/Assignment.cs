using System.Buffers.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Presets;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.TextCore.Text;

/*
Functional Specifications:

    Procedurally generate a 2D map in text form (string) using characters (such as *, #, $, @) to represent different elements of the map. 

Convert character - based maps into visual tilemaps using Unity's Tilemap component
Load and use pre-made maps from text files.

Implement basic player movement with collision detection based on tile types.


Requirements / Technical Specifications:
Create the following methods:
GenerateMapString(int width, int height) → Returns a string representation of a randomly generated map.
Use characters to represent different tilemap elements. (Example: '#' for wall, 'O' for door, '$' for chest, etc.)
            Implement a minimum of 3 basic procedural generation rules. (Examples: The map should have walls as a border. Doors should be placed next to walls, chests in corners with a maximum amount of chests per map.)
It should work with a size of at least at 10 by 15.
ConvertMapToTilemap(string mapData) → Converts a map string into Unity Tilemap.
Parse the string map data and place corresponding tiles in the Tilemap.
Define which characters correspond to which tile sprites.
Handle different tile types (walkable vs non-walkable).
LoadPremadeMap(string mapFilePath) → Loads a pre-made map from a text asset.
Read a map string from a text file. (Create the map text file. You should be able to edit the map in a notepad file and when running the game those changes should be reflected in the game's map.)
Use ConvertMapToTilemap() to display it.
Implement player movement:
Basic WASD or arrow key movement.
Collision detection using Tilemap's GetTile method. (Not Physics system, checking what is in that cell in the tilemap.)
Prevent walking on non-walkable tiles. (Example: Player shouldn't be able to walk over a wall, player shouldn't be able to walk over a chest.)

Sample Map String Format:
#########
###O  ###
##*  &###
##     ##
##$   O##
#########

Purpose:
Learn Unity's Tilemap system.
Understand procedural generation concepts.
Practice string manipulation and 2D array operations.
Implement basic game movement and collision detection (Without physics).
Work with Unity's component system.
Explore data structures (arrays, multidimensional arrays).
Explore loops, double nested loops.
Learn fundamentals of Unity C# programming.
Tips:
Look into multidimensional arrays (2D arrays).
Set up a basic Tilemap before implementing the conversion logic.
Test with a small, hardcoded map before implementing procedural generation.
Start by creating and testing the map generation in string format first.
Implement player movement separately, then integrate with the map and tile collision checking.
*/
