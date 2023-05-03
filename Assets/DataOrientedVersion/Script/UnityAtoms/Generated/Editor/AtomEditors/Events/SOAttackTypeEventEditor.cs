#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomEventEditor&lt;UnityRoyale.DataOriented.SOAttackType, SOAttackTypeEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SOAttackTypeEvent))]
    public sealed class SOAttackTypeEventEditor : AtomEventEditor<UnityRoyale.DataOriented.SOAttackType, SOAttackTypeEvent> { }
}
#endif
