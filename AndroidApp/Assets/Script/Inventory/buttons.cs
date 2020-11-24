using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : Singleton<buttons>
{
    private GameObject Unitprefab;
    private Sprite UnitSprite;


    
    [SerializeField]
    private Sprite HoverIcon;

    public void setSprite(Sprite value)
    {
        Debug.Log("Sprite " + value);
        this.UnitSprite = value;
        SetImage();
    }
    public void setPrefab(GameObject value)
    {
        Debug.Log("Prefab "+value);
            this.Unitprefab = value;
        
    }
    public GameObject unitprefab
    {
        get
        {
            return Unitprefab;
        }
    }

    public void SetImage()
    {
        Image image = GetComponentInChildren<Image>();
            //unitSlotTransform.Find("image").GetComponent<Image>();
        image.sprite = UnitSprite;
    }

    public Sprite Getsprite()
    { return HoverIcon; }
}
