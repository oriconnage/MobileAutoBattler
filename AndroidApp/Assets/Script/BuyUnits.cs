using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
    [System.Serializable]
    public struct Unit
    {
        // Is the Prefab index 
        public enum Type { Archer= 0, Melee = 1, Tank = 2, Mage = 3, Knight =4 };
        public Type type; // for defining the Type of units
    }

    [System.Serializable]
    public class BuyUnits: Singleton<BuyUnits>
    {
        public List<Unit> unitList; // List units 

       
        public BuyUnits() { unitList = new List<Unit>();}// Constructor

        //Generate 5 of each units type 
        public void Generate()
        {
            Unit newUnit = new Unit();
            
            for(int i =  0; i !=5; i++)
            {
                newUnit.type = (Unit.Type)i; // loops through the unit types
                for( int g = 0;g < 5; g++)
                {
                    this.unitList.Add(newUnit);
                  //  Debug.Log(unit[i]);
                }
            }
        }
        public static void  Shuffle(BuyUnits deck)
        {
            System.Random rnd = new System.Random();
            for(int i = 0; i < deck.unitList.Count; i++)
            {   
                //Random for Remaining pos
                int r = rnd.Next(i, deck.unitList.Count);
                //swapping the elements    
                Unit tmp = deck.unitList[i];
                deck.unitList[i] = deck.unitList[r];
                deck.unitList[r] = tmp;
               // Debug.Log(deck.unitList[i].type);
            }
          //  DrawCard(deck);
        }
        public static void DrawCard(BuyUnits deck)
        {
          
                for (int i=0;i !=3;i++ )
                {
                    Debug.Log(deck.unitList[i].type.ToString());
                    // Archer= 0, Melee = 1, Tank = 2, Mage = 3, Knight =4
                     switch (deck.unitList[i].type.ToString())
                     {
                        case "Archer":
                        Buy NewCard = Instantiate(Buy.Instance.Unitcard[0]).GetComponent<Buy>();
                        break;
                        case "Melee":
                        NewCard = Instantiate(Buy.Instance.Unitcard[1]).GetComponent<Buy>();
                        break;
                        case "Tank":
                        NewCard = Instantiate(Buy.Instance.Unitcard[2]).GetComponent<Buy>();
                        break;
                        case "Mage":
                        NewCard = Instantiate(Buy.Instance.Unitcard[3]).GetComponent<Buy>();
                        break;
                        case "Knight":
                        NewCard = Instantiate(Buy.Instance.Unitcard[4]).GetComponent<Buy>();
                        break;
            }

                }
        // Buy NewCard = Instantiate(Buy.Instance.Unitcard[]).GetComponent<Buy>();

    }
    }


