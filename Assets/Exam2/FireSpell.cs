using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public virtual void Cast()
    {
        Debug.Log($"Casting a Fire Spell! Burn them all!");
        Debug.Log($"Casting a spell on target Bad boy!");
        Debug.Log($"Casting a spell on target Bad boy! with power 5");

    }
    
   
}
