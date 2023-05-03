#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomDrawer&lt;SOTargetTypeEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOTargetTypeEvent))]
    public class SOTargetTypeEventDrawer : AtomDrawer<SOTargetTypeEvent> { }
}
#endif
