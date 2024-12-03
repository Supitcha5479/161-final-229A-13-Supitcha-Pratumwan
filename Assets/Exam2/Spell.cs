using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
    }
    public void Cast(string targetSpell)
    {
        //string target = targetSpell;
        Debug.Log($"Casting a spell on target{targetSpell}!");
    }
    public void Cast(string targetSpell, int attackSpell)
    {
        //string target = targetSpell;
        //int power = attackSpell;
        Debug.Log($"Casting a spell on target{targetSpell}! with power {attackSpell}");
    }

}
