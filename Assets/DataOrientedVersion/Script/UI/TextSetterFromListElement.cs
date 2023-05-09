using UnityEngine;
using TMPro;
using UnityRoyale.DataOriented;
using UnityAtoms;

namespace UnityRoyale.DataOriented.UI
{
    using CMRoute = ComponentMenuRoute;
    [AddComponentMenu(CMRoute.Root + CMRoute.UI + "TextSetterFromListElement")]
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TextSetterFromListElement : MonoBehaviour, IListElement
    {
        [SerializeField] int _listIndex;
        [SerializeField] BaseAtomValueList _list;

        private TextMeshProUGUI _text;

        public int ListIndex
        {
            get { return _listIndex; }
            set 
            {
                _listIndex = value;
                SetText();
            }
        }

        private void OnEnable()
        {
            SetText();
        }

        private void SetText()
        {
            if(_text == null) _text = GetComponent<TextMeshProUGUI>();
            _text.text = _list.IList[_listIndex].ToString();
        }
    }
}