using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cursor : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture,hotSpot,cursorMode);
    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
    }

}