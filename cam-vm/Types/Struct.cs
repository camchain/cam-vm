﻿using System.Collections.Generic;
using System.Linq;

namespace Cam.VM.Types
{
    internal class Struct : Array
    {
        public override bool IsStruct => true;

        public Struct(IEnumerable<StackItem> value) : base(value)
        {
        }

        public StackItem Clone()
        {
            List<StackItem> newArray = new List<StackItem>(this._array.Count);
            for (var i = 0; i < _array.Count; i++)
            {
                if (_array[i] is Struct s)
                {
                    newArray.Add(s.Clone());
                }
                else
                {
                    newArray.Add(_array[i]); //array = 是引用

                }
            }
            return new Struct(newArray);
        }

        public override bool Equals(StackItem other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (ReferenceEquals(null, other)) return false;
            Struct a = other as Struct;
            if (a == null)
                return false;
            else
                return _array.SequenceEqual(a._array);
        }
    }
}
