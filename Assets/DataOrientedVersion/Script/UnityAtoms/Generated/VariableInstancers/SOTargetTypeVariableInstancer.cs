using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomVariableInstancer&lt;SOTargetTypeVariable, SOTargetTypePair, UnityRoyale.DataOriented.SOTargetType, SOTargetTypeEvent, SOTargetTypePairEvent, SOTargetTypeSOTargetTypeFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/SOTargetType Variable Instancer")]
    public class SOTargetTypeVariableInstancer : AtomVariableInstancer<
        SOTargetTypeVariable,
        SOTargetTypePair,
        UnityRoyale.DataOriented.SOTargetType,
        SOTargetTypeEvent,
        SOTargetTypePairEvent,
        SOTargetTypeSOTargetTypeFunction>
    { }
}
