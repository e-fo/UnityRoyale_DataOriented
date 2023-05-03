using System;
using UnityEngine;
using UnityRoyale.DataOriented;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityRoyale.DataOriented.SOAttackType&gt;`. Inherits from `IPair&lt;UnityRoyale.DataOriented.SOAttackType&gt;`.
    /// </summary>
    [Serializable]
    public struct SOAttackTypePair : IPair<UnityRoyale.DataOriented.SOAttackType>
    {
        public UnityRoyale.DataOriented.SOAttackType Item1 { get => _item1; set => _item1 = value; }
        public UnityRoyale.DataOriented.SOAttackType Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityRoyale.DataOriented.SOAttackType _item1;
        [SerializeField]
        private UnityRoyale.DataOriented.SOAttackType _item2;

        public void Deconstruct(out UnityRoyale.DataOriented.SOAttackType item1, out UnityRoyale.DataOriented.SOAttackType item2) { item1 = Item1; item2 = Item2; }
    }
}