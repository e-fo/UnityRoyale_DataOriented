using UnityEngine;
using System;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomVariable&lt;UnityRoyale.DataOriented.SOAttackType, SOAttackTypePair, SOAttackTypeEvent, SOAttackTypePairEvent, SOAttackTypeSOAttackTypeFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/SOAttackType", fileName = "SOAttackTypeVariable")]
    public sealed class SOAttackTypeVariable : AtomVariable<UnityRoyale.DataOriented.SOAttackType, SOAttackTypePair, SOAttackTypeEvent, SOAttackTypePairEvent, SOAttackTypeSOAttackTypeFunction>
    {
        protected override bool ValueEquals(UnityRoyale.DataOriented.SOAttackType other)
        {
            throw new NotImplementedException();
        }
    }
}
