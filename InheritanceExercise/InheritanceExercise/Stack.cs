using System;
using System.Collections.Generic;

namespace InheritanceExercise
{
    public class Stack
    {
        readonly List<object> _stacked = new List<object>();
        
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Object cannot be null!");
            } 
            
            _stacked.Insert(0, obj);    
        }

        public object Pop()
        {
            if (_stacked.Count <= 0)
            {
                throw new InvalidOperationException("List is already empty, nothing to remove!");
            }
            
            var popped = _stacked[0];
            _stacked.Remove(_stacked[0]);
            
            return popped;   
        }

        public void Clear()
        {
            _stacked.Clear();
        }
    }
}