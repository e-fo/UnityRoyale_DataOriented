using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomVariableInstancer&lt;SOAttackTypeVariable, SOAttackTypePair, UnityRoyale.DataOriented.SOAttackType, SOAttackTypeEvent, SOAttackTypePairEvent, SOAttackTypeSOAttackTypeFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/SOAttackType Variable Instancer")]
    public class SOAttackTypeVariableInstancer : AtomVariableInstancer<
        SOAttackTypeVariable,
        SOAttackTypePair,
        UnityRoyale.DataOriented.SOAttackType,
        SOAttackTypeEvent,
        SOAttackTypePairEvent,
        SOAttackTypeSOAttackTypeFunction>
    { }
}
