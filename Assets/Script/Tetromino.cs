using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetromino
{
    I,
    O,
    T,
    J,
    L,
    S,
    Z
}

[System.Serializable]
public struct TetrominiData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells;
}
