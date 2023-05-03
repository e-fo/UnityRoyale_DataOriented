using UnityEditor;
using UnityAtoms.Editor;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityRoyale.DataOriented.SOAttackType`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SOAttackTypeVariable))]
    public sealed class SOAttackTypeVariableEditor : AtomVariableEditor<UnityRoyale.DataOriented.SOAttackType, SOAttackTypePair> { }
}
