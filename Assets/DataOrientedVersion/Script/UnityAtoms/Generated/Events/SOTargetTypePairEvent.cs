using UnityEngine;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `SOTargetTypePair`. Inherits from `AtomEvent&lt;SOTargetTypePair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SOTargetTypePair", fileName = "SOTargetTypePairEvent")]
    public sealed class SOTargetTypePairEvent : AtomEvent<SOTargetTypePair>
    {
    }
}
