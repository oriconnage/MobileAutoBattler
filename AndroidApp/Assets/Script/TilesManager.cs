using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TilesManager : MonoBehaviour
{

    public Point GridPosition { get;  set; }
 
    public void Setup(Point gridpos, Vector3 worldpos, Transform Folder)
    {
        // put tiles in a folder when loaded
        transform.SetParent(Folder);

        //set grid position 
        GridPosition = gridpos;

        //set world pos
        transform.position = worldpos;

        // spreads the tiles out
        transform.localScale = Vector3.one * (0.5f);
        
        //Debug.Log(gridpos);

        // store the cords in the dictionary created in LevelSetup
        LevelSetup.Instance.Tiles.Add(gridpos, this);
    }

    private void OnMouseOver()
    {
        if (!EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.Clickedbutton != null)
      {
            if (Input.GetMouseButtonDown(0))
         {
                Placement();
                Debug.Log(GridPosition);
         }


       }
    }

    private void Placement()
    {
      GameObject tmp = Instantiate(GameManager.Instance.Clickedbutton.unitprefab, transform.position, Quaternion.identity);
        tmp.GetComponent<MeshRenderer>().sortingOrder = GridPosition.Y;
        tmp.transform.SetParent(transform);
       GameManager.Instance.PlaceUnit();
    }
}