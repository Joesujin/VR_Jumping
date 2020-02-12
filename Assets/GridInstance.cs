using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridInstance : MonoBehaviour
{
    public GameObject TilePrefab;
    public List<tile> tiles;
    public int numX = 3;
    public int numY = 4;

    // Start is called before the first frame update
    void Start()
    {
        resetGrid();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            resetGrid();
        }
        
    }

    public void resetGrid()
    {
        tiles = new List<tile>(numX + numY);
        if (tiles.Count != null)
        {
            tiles.Clear();

        }

        for (int i = 0; i <= numX; i++)
        {
            for (int j = 0; j <= numY; j++)
            {

                if (Random.Range(0, 3) < 1)
                {
                    tiles[i+j].block = Instantiate(TilePrefab, new Vector3(i, 0, j), Quaternion.identity);
                }

            }
        }
    }
}
