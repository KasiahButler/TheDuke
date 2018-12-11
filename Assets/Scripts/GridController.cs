using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GridController : MonoBehaviour
{
	Node[,] Nodes;

	[SerializeField]
	private GameObject StartingNode;
	[SerializeField]
	private Transform NodeParent;
	[SerializeField]
	private GameObject NodePrefab;
	[SerializeField]
	private float GridPadding;
	[SerializeField]
	private float FloatingHeight;

	public void Start()
	{
		GenerateGrid();
	}

	public void GenerateGrid()
	{
		MeshRenderer nodeMesh = StartingNode.GetComponent<MeshRenderer>();
		float spacing = (nodeMesh.bounds.size.x * nodeMesh.transform.lossyScale.x) + GridPadding;
		Nodes = new Node[6,6];

		float xPos = StartingNode.transform.position.x;
		float zStartPos = StartingNode.transform.position.z;
		for(int i = 0; i < 6; i++)
		{
			float zPos = zStartPos;

			for(int j = 0; j < 6; j++)
			{
				Node newNode = Instantiate<GameObject>(NodePrefab, new Vector3(xPos, FloatingHeight, zPos), Quaternion.identity, NodeParent).GetComponent<Node>();
				newNode.SetGridPosition(new Vector2(i, j));

				Nodes[i,j] = newNode;

				zPos += spacing;
			}

			xPos += spacing;
		}
	}

	public void MoveTile()
	{

	}

	public void PlaceTile()
	{

	}
}
