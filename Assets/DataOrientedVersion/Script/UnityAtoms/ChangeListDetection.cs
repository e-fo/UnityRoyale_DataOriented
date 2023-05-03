using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using System;

namespace UnityRoyale
{
    public class ChangeListDetection
    {
        private List<int> List = new List<int>();

        public int this[int idx]
        {   
            get{ return List[idx]; }
            set { List[idx] = value; }
        }
        public Action<int, int> ElementChanged;
    }

    public class ValueListChangedEvent
    {
        public int Idx;

        public Action<int> Changed;
    }
}
