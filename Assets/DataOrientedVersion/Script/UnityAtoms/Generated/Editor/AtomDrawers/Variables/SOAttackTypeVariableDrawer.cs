#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomDrawer&lt;SOAttackTypeVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SOAttackTypeVariable))]
    public class SOAttackTypeVariableDrawer : VariableDrawer<SOAttackTypeVariable> { }
}
#endif
