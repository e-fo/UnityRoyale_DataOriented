using System;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `SOTargetTypePair`. Inherits from `AtomEventReference&lt;SOTargetTypePair, SOTargetTypeVariable, SOTargetTypePairEvent, SOTargetTypeVariableInstancer, SOTargetTypePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOTargetTypePairEventReference : AtomEventReference<
        SOTargetTypePair,
        SOTargetTypeVariable,
        SOTargetTypePairEvent,
        SOTargetTypeVariableInstancer,
        SOTargetTypePairEventInstancer>, IGetEvent 
    { }
}
