using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public int width;
    public int height;
    public int nodeNum;
    public int minDis;

    public GameObject deviceNode;

    public List<Node> netMap = new List<Node>();

    private void Start()
    {
        for (int i = 0; i < nodeNum; i++)
        {
            netMap.Add(GenerateNetMap());
        }
    }
    private Node GenerateNetMap()
    {
        int x = Random.Range(-width / 2 + minDis / 2, width / 2 - minDis / 2);
        int y = Random.Range(-height / 2 + minDis / 2, height / 2 - minDis / 2);

        Vector2 CurCoordinate = new Vector2(x, y);

        foreach (Node node in netMap)
        {
            if (Vector2.Distance(CurCoordinate, node.Coordinate) < minDis)
            {
                return GenerateNetMap();
            }
        }

        GameObject go = Instantiate(deviceNode,transform);
        go.GetComponent<RectTransform>().anchoredPosition = CurCoordinate;
        return new Node(CurCoordinate);
    }
}
