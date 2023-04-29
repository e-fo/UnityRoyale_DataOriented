using System;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityRoyale.DataOriented
{
    [Serializable]
    public struct AnimatorParamSetter<T> where T: AtomEventBase 
    {
        public string ParamName;
        public T Event;

        private Animator _animator;

        public void Register(Animator animator)
        {
            _animator = animator;

            if(Event is FloatEvent eFloat)
                eFloat.Register(OnFloatEventRaised);
            if(Event is BoolEvent eBool)
                eBool.Register(OnBoolEventRaised);
            if(Event is IntEvent eInt)
                    eInt.Register(OnIntEventRaised);
            if(Event is VoidEvent eTrigger)
                eTrigger.Register(OnTriggerEventRaised);
        }

        public void Unregister() 
        {
            if(Event is FloatEvent eFloat)
                eFloat.Register(OnFloatEventRaised);
            if(Event is BoolEvent eBool)
                eBool.Register(OnBoolEventRaised);
            if(Event is IntEvent eInt)
                eInt.Register(OnIntEventRaised);
            if(Event is VoidEvent eTrigger)
                eTrigger.Register(OnTriggerEventRaised);

            _animator = null;
        }

        public void OnTriggerEventRaised()
        {
            _animator?.SetTrigger(ParamName);
        }

        public void OnBoolEventRaised(bool param)
        {
            _animator?.SetBool(ParamName, param);
        }

        public void OnIntEventRaised(int param)
        {
            _animator?.SetInteger(ParamName, param);
        }

        public void OnFloatEventRaised(float param)
        {
            _animator?.SetFloat(ParamName, param);
        }
    }

    [AddComponentMenu("DataOrientedRoyale/Animation/ParamSetterByEvent")]
    [RequireComponent(typeof(Animator))]
    public class AnimatorParamSetterByEvent : MonoBehaviour
    {
        [SerializeField] AnimatorParamSetter<VoidEvent>[] _triggerParams;
        [SerializeField] AnimatorParamSetter<BoolEvent>[] _boolParams;
        [SerializeField] AnimatorParamSetter<IntEvent>[] _intParams;
        [SerializeField] AnimatorParamSetter<FloatEvent>[] _floatParams;
        
        private Animator _animator;

        void OnEnable()
        {
            _animator = GetComponent<Animator>();
            foreach(var p in _triggerParams) p.Register(_animator);
            foreach(var p in _boolParams) p.Register(_animator);
            foreach(var p in _intParams) p.Register(_animator);
            foreach(var p in _floatParams) p.Register(_animator);
        }
        private void OnDisable()
        {
            foreach(var p in _triggerParams) p.Unregister();
            foreach(var p in _boolParams) p.Unregister();
            foreach(var p in _intParams) p.Unregister();
            foreach(var p in _floatParams) p.Unregister();
        }
    }
}