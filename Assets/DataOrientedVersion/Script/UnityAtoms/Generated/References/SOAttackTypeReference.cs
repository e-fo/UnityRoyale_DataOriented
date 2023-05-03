using System;
using UnityAtoms.BaseAtoms;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomReference&lt;UnityRoyale.DataOriented.SOAttackType, SOAttackTypePair, SOAttackTypeConstant, SOAttackTypeVariable, SOAttackTypeEvent, SOAttackTypePairEvent, SOAttackTypeSOAttackTypeFunction, SOAttackTypeVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SOAttackTypeReference : AtomReference<
        UnityRoyale.DataOriented.SOAttackType,
        SOAttackTypePair,
        SOAttackTypeConstant,
        SOAttackTypeVariable,
        SOAttackTypeEvent,
        SOAttackTypePairEvent,
        SOAttackTypeSOAttackTypeFunction,
        SOAttackTypeVariableInstancer>, IEquatable<SOAttackTypeReference>
    {
        public SOAttackTypeReference() : base() { }
        public SOAttackTypeReference(UnityRoyale.DataOriented.SOAttackType value) : base(value) { }
        public bool Equals(SOAttackTypeReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityRoyale.DataOriented.SOAttackType other)
        {
            throw new NotImplementedException();
        }
    }
}
