#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SOTargetTypePair`. Inherits from `AtomEventEditor&lt;SOTargetTypePair, SOTargetTypePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SOTargetTypePairEvent))]
    public sealed class SOTargetTypePairEventEditor : AtomEventEditor<SOTargetTypePair, SOTargetTypePairEvent> { }
}
#endif
