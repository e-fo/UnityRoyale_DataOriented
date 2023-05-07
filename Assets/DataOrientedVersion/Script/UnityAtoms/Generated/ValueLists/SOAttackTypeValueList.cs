using UnityEngine;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomValueList&lt;UnityRoyale.DataOriented.SOAttackType, SOAttackTypeEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/SOAttackType", fileName = "SOAttackTypeValueList")]
    public sealed class SOAttackTypeValueList : AtomValueList<UnityRoyale.DataOriented.SOAttackType, SOAttackTypeEvent, IntEvent> { }
}
