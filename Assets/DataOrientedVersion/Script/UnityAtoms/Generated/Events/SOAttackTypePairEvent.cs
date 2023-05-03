using UnityEngine;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `SOAttackTypePair`. Inherits from `AtomEvent&lt;SOAttackTypePair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SOAttackTypePair", fileName = "SOAttackTypePairEvent")]
    public sealed class SOAttackTypePairEvent : AtomEvent<SOAttackTypePair>
    {
    }
}
