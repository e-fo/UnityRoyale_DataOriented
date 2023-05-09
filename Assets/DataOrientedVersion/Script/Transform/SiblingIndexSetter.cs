using UnityEngine;

namespace UnityRoyale.DataOriented
{
    using CMRoute = ComponentMenuRoute;
    [AddComponentMenu(CMRoute.Root + CMRoute.Transform + "SiblingIndexSetter")]
    [RequireComponent(typeof(Transform))]
    public class SiblingIndexSetter : MonoBehaviour, IListElement
    {
        [SerializeField] int _listIndex;
        [SerializeField] AtomListSorter _sorter;

        public int ListIndex
        {
            get => _listIndex; 
            set => _listIndex = value; 
        }

        void OnEnable()
        {
            _sorter.OnSorted.Register(OnOrderChanged);
        }

        void OnDisable()
        {
            _sorter.OnSorted.Unregister(OnOrderChanged);
        }

        void OnOrderChanged() 
        {
            transform.SetSiblingIndex(_sorter.AfterSortingIndexList[_listIndex]);
        }
    }
}