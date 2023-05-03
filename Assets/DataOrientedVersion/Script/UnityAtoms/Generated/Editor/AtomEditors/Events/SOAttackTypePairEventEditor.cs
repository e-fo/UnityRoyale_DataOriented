#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SOAttackTypePair`. Inherits from `AtomEventEditor&lt;SOAttackTypePair, SOAttackTypePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SOAttackTypePairEvent))]
    public sealed class SOAttackTypePairEventEditor : AtomEventEditor<SOAttackTypePair, SOAttackTypePairEvent> { }
}
#endif
