using UnityEngine;
using UnityAtoms;

namespace UnityRoyale.DataOriented
{
    using CMRoute = ComponentMenuRoute;

    [AddComponentMenu(CMRoute.Root + CMRoute.Transform + "GameObjectInstancerByListCount")]
    [RequireComponent(typeof(Transform))]
    public class GameObjectInstancerByListCount : MonoBehaviour
    {
        public bool SetIndexForElements = false;
        [SerializeField] BaseAtomValueList _valueList;
        [SerializeField] GameObject _prefab;
        [SerializeField] Transform _parent;

        [SerializeField] bool _sortWhenAllCreated = true;
        [SerializeField] AtomListSorter _listSorter;

        private void OnEnable()
        {
            int count = _valueList.IList.Count;

            for (int i = 0; i < count; i++)
            {
                var t = Instantiate(_prefab, _parent).transform;
                if (SetIndexForElements)
                {
                    var elements = t.GetComponentsInChildren<IListElement>();
                    for (int j = 0; j < elements.Length; j++)
                    {
                        var element = elements[j];
                        element.ListIndex = i;
                    }
                }
            }

            if(_sortWhenAllCreated && _listSorter != null)
            {
                _listSorter.Sort();
            }
        }
    }
}