using UnityEngine;
using UnityAtoms.BaseAtoms;
using System.Collections.Generic;

namespace UnityRoyale.DataOriented
{
    public abstract class AtomListSorter : ScriptableObject
    {
        public List<int> AfterSortingIndexList;
        public VoidEvent OnSorted;

        private void OnEnable()
        {
            Sort();
        }

        public abstract void Sort();
    }
}