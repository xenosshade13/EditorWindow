using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [Header("Static Values")]
    //public int strength;
    //public int body;
    //public int will;

    public CubeStats cube;

    [Header("Calculated Values")]
    public int health;
    public int mana;
    public int charisma;

    [Header("Stat")]
    public string stat = "Enter stat here";
}
