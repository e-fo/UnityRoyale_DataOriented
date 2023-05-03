using System;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `SOAttackTypePair`. Inherits from `AtomEventReference&lt;SOAttackTypePair, SOAttackTypeVariable, SOAttackTypePairEvent, SOAttackTypeVariableInstancer, SOAttackTypePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOAttackTypePairEventReference : AtomEventReference<
        SOAttackTypePair,
        SOAttackTypeVariable,
        SOAttackTypePairEvent,
        SOAttackTypeVariableInstancer,
        SOAttackTypePairEventInstancer>, IGetEvent 
    { }
}
