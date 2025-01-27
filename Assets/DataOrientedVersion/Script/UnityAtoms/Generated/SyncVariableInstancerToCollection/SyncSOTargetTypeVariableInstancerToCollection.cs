using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityRoyale.DataOriented;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type UnityRoyale.DataOriented.SOTargetType to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync SOTargetType Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncSOTargetTypeVariableInstancerToCollection : SyncVariableInstancerToCollection<UnityRoyale.DataOriented.SOTargetType, SOTargetTypeVariable, SOTargetTypeVariableInstancer> { }
}
