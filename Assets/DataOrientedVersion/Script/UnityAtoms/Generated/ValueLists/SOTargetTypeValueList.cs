using UnityEngine;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomValueList&lt;UnityRoyale.DataOriented.SOTargetType, SOTargetTypeEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/SOTargetType", fileName = "SOTargetTypeValueList")]
    public sealed class SOTargetTypeValueList : AtomValueList<UnityRoyale.DataOriented.SOTargetType, SOTargetTypeEvent> { }
}
