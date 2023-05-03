using UnityEngine;
using UnityAtoms.BaseAtoms;
using DG.Tweening;

namespace UnityRoyale.DataOriented.TransformComp
{
    using CMRoute = ComponentMenuRoute;
    [AddComponentMenu(CMRoute.Root + CMRoute.Transform + "RectTransformMoveAnchorPosByTween")]
    [RequireComponent(typeof(RectTransform))]
    public class RectTransformMoveAnchorPosByTween : MonoBehaviour
    {
        [SerializeField] Vector2Event _moveEvent;
        [SerializeField] float _duration;
        [SerializeField] Ease _ease;

        private Vector2 _targetPos;
        private RectTransform _rectTransform;

        private void OnEnable()
        {
            _moveEvent.Register(Move);
            _rectTransform = GetComponent<RectTransform>();
        }

        private void OnDisable()
        {
            _moveEvent.Unregister(Move);
        }

        void Move(Vector2 pos)
        {
            _targetPos = pos;
            _rectTransform.DOAnchorPos(_targetPos, _duration).SetEase(_ease);
        }
    }
}