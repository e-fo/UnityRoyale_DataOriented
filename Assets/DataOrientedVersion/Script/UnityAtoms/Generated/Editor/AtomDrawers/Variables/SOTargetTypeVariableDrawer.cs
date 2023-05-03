#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomDrawer&lt;SOTargetTypeVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOTargetTypeVariable))]
    public class SOTargetTypeVariableDrawer : VariableDrawer<SOTargetTypeVariable> { }
}
#endif
