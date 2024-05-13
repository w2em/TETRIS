using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{
    public Tilemap tilemap { get; private set; }
    public TetrominiData[] tetrominies;

    private void Awake()
    {
        this.tilemap = GetComponentInChildren<Tilemap>();

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
    }

    public void Set()
    {

    }
}
