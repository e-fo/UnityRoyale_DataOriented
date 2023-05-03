using UnityEngine;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomEventReferenceListener&lt;UnityRoyale.DataOriented.SOTargetType, SOTargetTypeEvent, SOTargetTypeEventReference, SOTargetTypeUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SOTargetType Event Reference Listener")]
    public sealed class SOTargetTypeEventReferenceListener : AtomEventReferenceListener<
        UnityRoyale.DataOriented.SOTargetType,
        SOTargetTypeEvent,
        SOTargetTypeEventReference,
        SOTargetTypeUnityEvent>
    { }
}
