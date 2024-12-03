using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public virtual void Cast()
    {
        Debug.Log($"Casting a Ice Spell! freeze the enemy ");
        Debug.Log($"Casting a spell on target Slime!");
        Debug.Log($"Casting a spell on target Slime! with power 5");
    }
   
    
}
