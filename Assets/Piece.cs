using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
	public int grid_x = 0;
	public int grid_y = 0;

	bool picked_up = false;

    GameObject cursor;

    // On Init
    void Awake()
    {
        cursor = GameObject.FindWithTag("Cursor");
    }

    // Start is called before the first frame update
    void Start()
    {
    	Debug.Log(Chess.GetAlgebraicNotation(grid_x, grid_y));
    }

    // Called when mouse hovers over piece.
    void OnMouseEnter()
    {
        cursor.SetActive(true);
        cursor.transform.position = gameObject.transform.position;
    }

    void OnMouseExit()
    {
        cursor.SetActive(false);
        cursor.transform.position = Cursor.default_position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
