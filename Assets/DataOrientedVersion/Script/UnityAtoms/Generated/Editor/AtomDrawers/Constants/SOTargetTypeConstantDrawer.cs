#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomDrawer&lt;SOTargetTypeConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOTargetTypeConstant))]
    public class SOTargetTypeConstantDrawer : VariableDrawer<SOTargetTypeConstant> { }
}
#endif
