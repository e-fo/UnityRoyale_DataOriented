using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityRoyale.DataOriented.TransformComp
{
    using CMRoute = ComponentMenuRoute;

    [AddComponentMenu(CMRoute.Root + CMRoute.Transform + "LookAtPos")]
    [RequireComponent(typeof(Transform))]
    public class TransformLookAtPos : MonoBehaviour
    {
        [SerializeField] Vector3Event _moveInputEvent;

        void OnEnable()
        {
            _moveInputEvent.Register(LookAt);
        }
        void OnDisable()
        {
            _moveInputEvent.Unregister(LookAt);
        }

        private void LookAt(Vector3 pos)
        {
            var targetPos = pos;
            targetPos.y = transform.position.y;
            transform.LookAt(targetPos);
        }
    }
}
