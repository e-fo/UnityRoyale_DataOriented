using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityAtoms;

namespace UnityRoyale.DataOriented
{
    [CreateAssetMenu(menuName = "Event/InputSystem/LeftClickRaycast")]
    public class InputPlaneRaycasterEvent : AtomEvent<Vector3>
    {
        private LayerMask layerMask;

        private InputAction _leftClickedAction;

        void OnEnable()
        {
            _leftClickedAction = new InputAction("leftClickAction", InputActionType.Button, "<Mouse>/leftButton");
            _leftClickedAction.Enable();
            _leftClickedAction.performed += OnLeftClick;
        }

        void OnDisable()
        {
            _leftClickedAction.performed -= OnLeftClick;
            _leftClickedAction.Disable();
        }

        void OnLeftClick(InputAction.CallbackContext context)
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                Raise(hit.point);
            }
        }
    }
}