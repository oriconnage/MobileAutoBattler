using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_Inventory : MonoBehaviour
{
    private Inventory inventory;

    [SerializeField]
    private Transform UnitSlotContainer;
    [SerializeField]
    private GameObject SlotPrefab;

   // public Inventory Inventory {  set => inventory = value;
    public void SetInventory(Inventory tmp)
    {
        
        Debug.Log("SetInventory");
        inventory = tmp;
        PopulateInventory();

    }

    public void PopulateInventory()
    {
        Debug.Log("there's "+ inventory.GetUnitList.Count);

        for (int i = 0; i < inventory.GetUnitList.Count; i++)
        {
            //instantiate the slot
            GameObject UnitSlot = Instantiate(SlotPrefab, UnitSlotContainer);

            Debug.Log("Ref " + inventory.GetUnitList[i].name);
            //displaying the unit 
            buttons.Instance.setSprite(inventory.GetUnitList[i].sprite);
            buttons.Instance.setPrefab(inventory.GetUnitList[i].prefab);
        }

    }
/**
    public void RefeshInventoryItems()
    {
        Debug.Log("This function is called"+ inventory.GetUnitList.Count);

        for (int i = 0; i < inventory.GetUnitList.Count; i++)
        {
            //instantiate the slot
            GameObject UnitSlot = Instantiate(SlotPrefab, UnitSlotContainer);

            Debug.Log("Ref " + inventory.GetUnitList[i].name);
            //displaying the unit 
            buttons.Instance.setSprite(inventory.GetUnitList[i].sprite);
            buttons.Instance.setPrefab(inventory.GetUnitList[i].prefab);
        }
       
    }
**/
}
