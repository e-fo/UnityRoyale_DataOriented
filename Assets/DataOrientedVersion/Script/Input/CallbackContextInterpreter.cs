using UnityEngine.InputSystem;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;

namespace UnityRoyale.DataOriented
{
    [CreateAssetMenu(menuName = "Unity Atoms/Input System/Interpreters/Void")]
    public class CallbackContextInterpreter : BaseAtom
    {
        [SerializeField] VoidEvent _started;
        [SerializeField] VoidEvent _performed;
        [SerializeField] VoidEvent _canceled;
        [SerializeField] VoidEvent _waiting;
        [SerializeField] VoidEvent _disabled;

        public void Raise(InputAction.CallbackContext context)
        {
            switch (context.phase)
            {
                case InputActionPhase.Disabled:
                if (_disabled)
                {
                    _disabled.Raise();
                }
                break;
                case InputActionPhase.Waiting:
                if (_waiting)
                {
                    _waiting.Raise();
                }
                break;
                case InputActionPhase.Started:
                if (_started)
                {
                    _started.Raise();
                }
                break;
                case InputActionPhase.Performed:
                if (_performed)
                {
                    _performed.Raise();
                }
                break;
                case InputActionPhase.Canceled:
                if (_canceled)
                {
                    _canceled.Raise();
                }
                break;
            }
        }
    }
}