using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `SetVariableValue&lt;UnityRoyale.DataOriented.SOTargetType, SOTargetTypePair, SOTargetTypeVariable, SOTargetTypeConstant, SOTargetTypeReference, SOTargetTypeEvent, SOTargetTypePairEvent, SOTargetTypeVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/SOTargetType", fileName = "SetSOTargetTypeVariableValue")]
    public sealed class SetSOTargetTypeVariableValue : SetVariableValue<
        UnityRoyale.DataOriented.SOTargetType,
        SOTargetTypePair,
        SOTargetTypeVariable,
        SOTargetTypeConstant,
        SOTargetTypeReference,
        SOTargetTypeEvent,
        SOTargetTypePairEvent,
        SOTargetTypeSOTargetTypeFunction,
        SOTargetTypeVariableInstancer>
    { }
}
