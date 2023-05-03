using UnityEngine;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `SOTargetTypePair`. Inherits from `AtomEventReferenceListener&lt;SOTargetTypePair, SOTargetTypePairEvent, SOTargetTypePairEventReference, SOTargetTypePairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SOTargetTypePair Event Reference Listener")]
    public sealed class SOTargetTypePairEventReferenceListener : AtomEventReferenceListener<
        SOTargetTypePair,
        SOTargetTypePairEvent,
        SOTargetTypePairEventReference,
        SOTargetTypePairUnityEvent>
    { }
}
