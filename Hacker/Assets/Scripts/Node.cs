using UnityEngine;
public class Node
{
    public string deviceName;
    public string IPAddr;

    private Vector2 coordinate;

    public Node(Vector2 coordinate)
    {
        Coordinate = coordinate;
    }

    public Vector2 Coordinate { get => coordinate; set => coordinate = value; }
}
