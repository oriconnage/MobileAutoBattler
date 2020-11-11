using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
   
    private double gold;
    private double gem;

    [SerializeField]
    private Text Goldtext;

    [SerializeField]
    private Text Gemtext;

    public buttons Clickedbutton { get; private set; }
    public double Gold
    {
        get
        { return gold; }

        set
        {
            gold = value;
            Goldtext.text = value.ToString() + "<color=lime>£</color>";
        }
    }

    public double Gem
    {
        get
        { 
            return gem; 
        }
        set
        {
            gem = value;
            Gemtext.text = value.ToString() + "<color=lime>G</color>";
        }
    }

    void Start()
    {
        Gold = 1000;
        Gem = 0;
    }

    // when we select a unit to place onto the map
    public void Selecton(buttons Buttons)
    {
        Clickedbutton = Buttons;
        Hoverscript.Instance.Hoveractivation(Buttons.Getsprite());
    }
    // once we place the unit onto the map
  public void BuyUnit()
  {
       Clickedbutton = null;
       Hoverscript.Instance.Hoveractivation(null);
  }
}
