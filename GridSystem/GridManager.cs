using UnityEngine;

public class GridManager : MonoBehaviour
{
    public Vector2 worldGridSize

    private void Start()
    {
        CreateWorldGrids();
    }

    public void UpdateWorldGridSize(Vector2 targetSize)
    {
        worldGridSize = targetSize;
        CreateWorldGrids();
    }

    public void CreateWorldGrids() => WorldGrid grid = new WorldGrid((int)worldGridSize.x, (int)worldGridSize.y);
}