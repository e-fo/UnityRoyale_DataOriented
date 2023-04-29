using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityEngine.InputSystem;

namespace UnityRoyale.DataOriented
{
    [CreateAssetMenu(menuName = "Unity Atoms/Input System/Interpreters/CamToMouseRaycaster")]
    public class CallbackContextInterpreterCamToMouseRaycaster : ScriptableObject
    {
        [SerializeField] LayerMask _layerMask;
        [SerializeField] float _rayMaxDistance;

        [SerializeField] Vector3Event _started;
        [SerializeField] Vector3Event _performed;
        [SerializeField] Vector3Event _canceled;
        [SerializeField] Vector3Event _waiting;
        [SerializeField] Vector3Event _disabled;

        public void Raycast(InputAction.CallbackContext context)
        {
            Vector3Event @event = null;
            switch (context.phase)
            {
                case InputActionPhase.Disabled:
                if (_disabled)
                {
                    @event = _disabled;
                }
                break;
                case InputActionPhase.Waiting:
                if (_waiting)
                {
                     @event = _waiting;
                }
                break;
                case InputActionPhase.Started:
                if (_started)
                {
                    @event = _started;
                }
                break;
                case InputActionPhase.Performed:
                if (_performed)
                {
                    @event = _performed;
                }
                break;
                case InputActionPhase.Canceled:
                if (_canceled)
                {
                    @event = _canceled;
                }
                break;
            }

            @event?.Raise(GetHitPoint());
        }

        private Vector3 GetHitPoint()
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            Vector3 ret = default;

            if (Physics.Raycast(ray, out hit, _rayMaxDistance, _layerMask))
            {
                ret = hit.point;
            }

            return ret;
        }
    }
}
