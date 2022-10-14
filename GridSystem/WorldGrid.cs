using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGrid
{
    private int width;
    private int length;

    public int[,] gridArray;

    public Grid(int width, int length)
    {
        this.width = width;
        this.length = length;

        gridArray = new int[width, lenght];
    
        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for(int y = 0; y < gridArray.GetLength(1); y++)
            {
                Debug.Log(x + " ,  " + y);
            }
        }
    } 
}
