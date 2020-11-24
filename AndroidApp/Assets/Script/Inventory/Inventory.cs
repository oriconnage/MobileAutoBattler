using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<ClassObject> UnitListContainer;

    public Inventory()
    {
        UnitListContainer = new List<ClassObject>();
        //AddUnits(new Unit { type = Unit.Type.Mage });
        Debug.Log("Create a Inventory");
    }
    public void AddUnits (ClassObject unit)
    {
        UnitListContainer.Add(unit);
        Debug.Log("Adding "+ UnitListContainer.Count);
        foreach(ClassObject x in GetUnitList)
        {
            Debug.Log("just added a "+x.name);
        }
    }
    public List<ClassObject> GetUnitList
    {
        get
        { 
            return UnitListContainer;
        }
    }

}