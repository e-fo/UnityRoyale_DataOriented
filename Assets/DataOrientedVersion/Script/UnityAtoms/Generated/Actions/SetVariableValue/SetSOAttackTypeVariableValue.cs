using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `SetVariableValue&lt;UnityRoyale.DataOriented.SOAttackType, SOAttackTypePair, SOAttackTypeVariable, SOAttackTypeConstant, SOAttackTypeReference, SOAttackTypeEvent, SOAttackTypePairEvent, SOAttackTypeVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/SOAttackType", fileName = "SetSOAttackTypeVariableValue")]
    public sealed class SetSOAttackTypeVariableValue : SetVariableValue<
        UnityRoyale.DataOriented.SOAttackType,
        SOAttackTypePair,
        SOAttackTypeVariable,
        SOAttackTypeConstant,
        SOAttackTypeReference,
        SOAttackTypeEvent,
        SOAttackTypePairEvent,
        SOAttackTypeSOAttackTypeFunction,
        SOAttackTypeVariableInstancer>
    { }
}
