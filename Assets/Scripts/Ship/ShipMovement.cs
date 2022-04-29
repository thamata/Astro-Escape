using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ShipMovement : MonoBehaviour
{
    [SerializeField] private int shipNumber;


    void OnMouseDrag()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, 0);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);


        if (objPosition.x > -2 && objPosition.x < 2)
        {
            switch (shipNumber)
            {
                case 1:
                    transform.position = new Vector2(objPosition.x, 0);
                    break;
                case 2:
                    transform.position = new Vector2(objPosition.x, -1.94f);
                    break;
                case 3:
                    transform.position = new Vector2(objPosition.x, -3.88f);
                    break;
            }
        }
    }
}

