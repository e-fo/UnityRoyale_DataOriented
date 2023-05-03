#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SOTargetTypePair`. Inherits from `AtomDrawer&lt;SOTargetTypePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOTargetTypePairEvent))]
    public class SOTargetTypePairEventDrawer : AtomDrawer<SOTargetTypePairEvent> { }
}
#endif
