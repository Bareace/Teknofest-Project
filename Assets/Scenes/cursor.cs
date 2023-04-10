using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.EventSystems;


public class cursor : MonoBehaviour{
    public Texture2D x;
    public Texture2D y;
    public CursorMode cursormode = CursorMode.Auto;
    public Vector2 hotspot = Vector2.zero;

    void Start(){
        Cursor.SetCursor(x, hotspot, cursormode);
    }
    public void OnMouseOver(){
        Cursor.SetCursor(y, hotspot, cursormode);
    }
    public void OnMouseExit(){
        Cursor.SetCursor(x, hotspot, cursormode);
    }

}