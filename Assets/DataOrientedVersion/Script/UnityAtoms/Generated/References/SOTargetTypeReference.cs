using System;
using UnityAtoms.BaseAtoms;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomReference&lt;UnityRoyale.DataOriented.SOTargetType, SOTargetTypePair, SOTargetTypeConstant, SOTargetTypeVariable, SOTargetTypeEvent, SOTargetTypePairEvent, SOTargetTypeSOTargetTypeFunction, SOTargetTypeVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOTargetTypeReference : AtomReference<
        UnityRoyale.DataOriented.SOTargetType,
        SOTargetTypePair,
        SOTargetTypeConstant,
        SOTargetTypeVariable,
        SOTargetTypeEvent,
        SOTargetTypePairEvent,
        SOTargetTypeSOTargetTypeFunction,
        SOTargetTypeVariableInstancer>, IEquatable<SOTargetTypeReference>
    {
        public SOTargetTypeReference() : base() { }
        public SOTargetTypeReference(UnityRoyale.DataOriented.SOTargetType value) : base(value) { }
        public bool Equals(SOTargetTypeReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityRoyale.DataOriented.SOTargetType other)
        {
            throw new NotImplementedException();
        }
    }
}
