using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    [SerializeField]
    private GameObject Playerprefab;

    [SerializeField]
    private Sprite HoverIcon;

    public GameObject playerprefab
    {
        get

        {
            return Playerprefab;
        }
    }

    public Sprite Getsprite()
    { return HoverIcon; }
}
