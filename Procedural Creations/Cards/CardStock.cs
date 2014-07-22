using UnityEngine;
using System.Collections;

public class CardStock : MonoBehaviour
{
	// Number of vertices in arc to control round-ness of corners (0 = square cards)
	public int Smooth = 2;
	// Shape name in atlas for back of card
	public string Back;
	// Shape name for color of border and transparent background
	public string Paper;
	// Size of card
	public Vector2 Size;
	// Corner = part of Size reserved for corners
	public float CornerSize;
	// Border = part of Size reserved for symbols etc.
	public Vector2 Border;
	// Basic material used for all generated meshes.
	public Material DefaultMaterial;
	
	public bool TwoSided = true;
	//public Texture2D BackQuarter;
	
	const float MinSize = 0.01f;
	
	public void Validate()
	{
		if (Smooth < 0)
		{
			Smooth = 0;
		}
		if (Size.x < MinSize)
		{
			Size.x = MinSize;
		}
		if (Size.y < MinSize)
		{
			Size.y = MinSize;
		}
		float maxCorner = Mathf.Min(Size.x,Size.y)*0.25f; 
		if (CornerSize > maxCorner)
		{
			CornerSize = maxCorner;
		}
		if (CornerSize < 0.01f*Mathf.Max(Size.x,Size.y))
		{
			Smooth = 0;
		}
		if (string.IsNullOrEmpty(Paper))
		{
			Debug.LogError("Paper must be set to a valid shape from your atlas.");
		}
		if (TwoSided && string.IsNullOrEmpty(Back))
		{
			Debug.LogError("Back must be set to a valid shape from your atlas.");
		}
	}
}
