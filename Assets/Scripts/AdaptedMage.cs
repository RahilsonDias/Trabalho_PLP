using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdaptedMage : MonoBehaviour, IEnemy
{
    public MageEnemy mage;

    public void Attack()
    {
        mage.CastSpell();
    }
}
