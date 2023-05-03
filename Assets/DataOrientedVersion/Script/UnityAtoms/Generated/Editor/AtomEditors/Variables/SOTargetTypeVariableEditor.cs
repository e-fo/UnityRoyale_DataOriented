using UnityEditor;
using UnityAtoms.Editor;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityRoyale.DataOriented.SOTargetType`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SOTargetTypeVariable))]
    public sealed class SOTargetTypeVariableEditor : AtomVariableEditor<UnityRoyale.DataOriented.SOTargetType, SOTargetTypePair> { }
}
