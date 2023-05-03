using UnityEngine;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomEventReferenceListener&lt;UnityRoyale.DataOriented.SOAttackType, SOAttackTypeEvent, SOAttackTypeEventReference, SOAttackTypeUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SOAttackType Event Reference Listener")]
    public sealed class SOAttackTypeEventReferenceListener : AtomEventReferenceListener<
        UnityRoyale.DataOriented.SOAttackType,
        SOAttackTypeEvent,
        SOAttackTypeEventReference,
        SOAttackTypeUnityEvent>
    { }
}
