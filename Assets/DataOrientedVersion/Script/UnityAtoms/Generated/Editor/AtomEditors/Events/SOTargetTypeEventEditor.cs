#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomEventEditor&lt;UnityRoyale.DataOriented.SOTargetType, SOTargetTypeEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SOTargetTypeEvent))]
    public sealed class SOTargetTypeEventEditor : AtomEventEditor<UnityRoyale.DataOriented.SOTargetType, SOTargetTypeEvent> { }
}
#endif
