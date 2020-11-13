using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : Singleton<Buy>
{
    [SerializeField]
    private int Cost;

    [SerializeField]
    private GameObject [] UnitPrefab;


    private BuyUnits cards;

    public GameObject[] Unitcard
    {
        get
        {
            return UnitPrefab;
        }

        set
        {
            UnitPrefab = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        cards = new BuyUnits();
        cards.Generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void drawThreecards()
    {
        if (Cost <= GameManager.Instance.Gold)
        {
            BuyUnits.Shuffle(cards);
            BuyUnits.DrawCard(cards);
        }
    }
   


}
