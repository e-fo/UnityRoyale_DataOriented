#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SOAttackTypePair`. Inherits from `AtomDrawer&lt;SOAttackTypePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOAttackTypePairEvent))]
    public class SOAttackTypePairEventDrawer : AtomDrawer<SOAttackTypePairEvent> { }
}
#endif
