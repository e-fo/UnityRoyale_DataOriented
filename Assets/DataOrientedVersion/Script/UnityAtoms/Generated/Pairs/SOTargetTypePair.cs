using System;
using UnityEngine;
using UnityRoyale.DataOriented;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityRoyale.DataOriented.SOTargetType&gt;`. Inherits from `IPair&lt;UnityRoyale.DataOriented.SOTargetType&gt;`.
    /// </summary>
    [Serializable]
    public struct SOTargetTypePair : IPair<UnityRoyale.DataOriented.SOTargetType>
    {
        public UnityRoyale.DataOriented.SOTargetType Item1 { get => _item1; set => _item1 = value; }
        public UnityRoyale.DataOriented.SOTargetType Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityRoyale.DataOriented.SOTargetType _item1;
        [SerializeField]
        private UnityRoyale.DataOriented.SOTargetType _item2;

        public void Deconstruct(out UnityRoyale.DataOriented.SOTargetType item1, out UnityRoyale.DataOriented.SOTargetType item2) { item1 = Item1; item2 = Item2; }
    }
}