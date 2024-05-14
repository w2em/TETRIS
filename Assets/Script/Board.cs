using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{
    public Tilemap tilemap { get; private set; }
    public Piece activePiece { get; private set; }
    public TetrominiData[] tetrominies;
    public Vector3Int spawnPosition;
    public Vector2Int boardSize = new Vector2Int(10, 20);

    private void Awake()
    {
        this.tilemap = GetComponentInChildren<Tilemap>();
        this.activePiece = GetComponentInChildren<Piece>();

        for (int i = 0;i<this.tetrominies.Length;i++)
        {
            this.tetrominies[i].Initialize();
        }
    }

    private void Start()
    {
        SpawnPiece();
    }

    public void SpawnPiece()
    {
        int random = Random.Range(0, tetrominies.Length);
        TetrominiData data = this.tetrominies[random];

        this.activePiece.Initialize(this,this.spawnPosition, data);
        Set(this.activePiece);
    }

    public void Set(Piece piece)
    {
        for (int i = 0; i < piece.cells.Length; i++)
        {
            Vector3Int tilePosition = piece.cells[i] + piece.position;
            this.tilemap.SetTile(tilePosition,piece.data.tile);
        }
    }

    /*
    public bool IsValidPosition(Piece piece, Vector3Int position)
    {
        for (int i = 0; i < piece.cells.Length; i++)
        {
            Vector3Int tilePosition = piece.cells[i] + position;

            if (this.tilemap.HasTile(tilePosition))
            {
                return false;
            }
        }
    }
    */
}
