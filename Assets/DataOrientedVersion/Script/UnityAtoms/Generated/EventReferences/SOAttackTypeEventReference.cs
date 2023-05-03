using System;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomEventReference&lt;UnityRoyale.DataOriented.SOAttackType, SOAttackTypeVariable, SOAttackTypeEvent, SOAttackTypeVariableInstancer, SOAttackTypeEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOAttackTypeEventReference : AtomEventReference<
        UnityRoyale.DataOriented.SOAttackType,
        SOAttackTypeVariable,
        SOAttackTypeEvent,
        SOAttackTypeVariableInstancer,
        SOAttackTypeEventInstancer>, IGetEvent 
    { }
}
