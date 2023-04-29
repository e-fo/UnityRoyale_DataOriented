using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityRoyale.DataOriented
{
    [AddComponentMenu("DataOrientedRoyale/Transform/MoveToPos")]
    [RequireComponent(typeof(Transform))]
    public class TransformMoveToPos : MonoBehaviour
    {
        [SerializeField] Vector3Event _moveInputEvent;
        [SerializeField] FloatVariable _moveSpeed;

        [SerializeField] BoolVariable _isMoving;

        private Vector3 _targetPos;

        void OnEnable()
        {
            _moveInputEvent.Register(Move);
        }
        void OnDisable()
        {
            _moveInputEvent.Unregister(Move);
        }

        private void Move(Vector3 pos)
        {
            _targetPos = pos;
            _targetPos.y = transform.position.y;
            _isMoving.Value = true;
        }

        private void Update()
        {
            if (!_isMoving) return;

            var transPos = transform.position;
            if(Vector3.Distance(transPos, _targetPos) > 0.5)
            {
                transform.position = Vector3.MoveTowards(transPos, _targetPos, _moveSpeed.Value*Time.deltaTime);
                
            }
            else
            {
                _isMoving.Value = false;
            }
        }
    }
}