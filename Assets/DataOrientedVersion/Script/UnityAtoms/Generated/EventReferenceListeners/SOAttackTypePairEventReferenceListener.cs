using UnityEngine;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `SOAttackTypePair`. Inherits from `AtomEventReferenceListener&lt;SOAttackTypePair, SOAttackTypePairEvent, SOAttackTypePairEventReference, SOAttackTypePairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SOAttackTypePair Event Reference Listener")]
    public sealed class SOAttackTypePairEventReferenceListener : AtomEventReferenceListener<
        SOAttackTypePair,
        SOAttackTypePairEvent,
        SOAttackTypePairEventReference,
        SOAttackTypePairUnityEvent>
    { }
}
