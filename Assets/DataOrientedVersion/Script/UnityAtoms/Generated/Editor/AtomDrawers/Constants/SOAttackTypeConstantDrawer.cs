#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomDrawer&lt;SOAttackTypeConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOAttackTypeConstant))]
    public class SOAttackTypeConstantDrawer : VariableDrawer<SOAttackTypeConstant> { }
}
#endif
