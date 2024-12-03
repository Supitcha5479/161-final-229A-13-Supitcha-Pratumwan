using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSpell : Spell
{
    public virtual void Cast()
    {
        Debug.Log($"Casting a Labubu Spell! enemy speak labubu unstopable");
        Debug.Log($"Casting a spell on target Lala!");
        Debug.Log($"Casting a spell on target lala! with power 4");
    }
    
    public string NewCastEnemy(string targetSpell, int attackSpell)
    {
        string target = "slime";
        target = targetSpell;
        int power = 5;
        power = attackSpell;
        return targetSpell + power;
       
    }
}
