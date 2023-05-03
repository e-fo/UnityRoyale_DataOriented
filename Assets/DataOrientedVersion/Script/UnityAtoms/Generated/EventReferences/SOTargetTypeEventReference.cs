using System;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomEventReference&lt;UnityRoyale.DataOriented.SOTargetType, SOTargetTypeVariable, SOTargetTypeEvent, SOTargetTypeVariableInstancer, SOTargetTypeEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOTargetTypeEventReference : AtomEventReference<
        UnityRoyale.DataOriented.SOTargetType,
        SOTargetTypeVariable,
        SOTargetTypeEvent,
        SOTargetTypeVariableInstancer,
        SOTargetTypeEventInstancer>, IGetEvent 
    { }
}
