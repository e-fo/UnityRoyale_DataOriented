using UnityEngine;
using System;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomVariable&lt;UnityRoyale.DataOriented.SOTargetType, SOTargetTypePair, SOTargetTypeEvent, SOTargetTypePairEvent, SOTargetTypeSOTargetTypeFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/SOTargetType", fileName = "SOTargetTypeVariable")]
    public sealed class SOTargetTypeVariable : AtomVariable<UnityRoyale.DataOriented.SOTargetType, SOTargetTypePair, SOTargetTypeEvent, SOTargetTypePairEvent, SOTargetTypeSOTargetTypeFunction>
    {
        protected override bool ValueEquals(UnityRoyale.DataOriented.SOTargetType other)
        {
            throw new NotImplementedException();
        }
    }
}
