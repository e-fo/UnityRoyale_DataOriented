using UnityAtoms.BaseAtoms;
using UnityEngine;

using System.Collections.Generic;

namespace UnityRoyale.DataOriented
{
    [CreateAssetMenu(menuName = "DataOrientedRoyale/UnityAtom/AtomListOrderingInt")]
    public class AtomFloatListSorter : AtomListSorter
    {
        [SerializeField] FloatValueList _valueList;
        [SerializeField] SortMethod _sortMethod;

        private int Compare(KeyValuePair<int, float> x, KeyValuePair<int, float> y)
        {
            var ret = x.Value < y.Value ? -1 : 1;
            ret = x.Value == y.Value ? 0 : ret;

            return ret;
        }

        public override void Sort()
        {
            base.AfterSortingIndexList = new List<int>(new int[_valueList.Count]);

            int count = _valueList.Count;
            List<KeyValuePair<int, float>> idxValMap = 
                new List<KeyValuePair<int, float>>(new KeyValuePair<int, float>[count]);

            for (int i=0; i<count; i++) 
            {
                idxValMap[i] = new KeyValuePair<int, float>(i, _valueList[i]);
            }
            idxValMap.Sort(Compare);

            if(_sortMethod == SortMethod.Descending) idxValMap.Reverse();

            for (int i=0; i<count; i++)
            {
                var e = idxValMap[i];
                base.AfterSortingIndexList[e.Key] = i;
            }
            OnSorted?.Raise();
        }
    }
}