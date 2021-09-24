﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddlewareLoader
{
    class MiddlewareModule : IEquatable<MiddlewareModule>, IComparable<MiddlewareModule>
    {
        public int Priority = 0;

        public virtual void Main(Dictionary<string, Object> args)
        {

        }

        public int CompareTo(MiddlewareModule other)
        {
            return (this.Priority == other.Priority) ? 1 : 0;
        }


        public bool Equals(MiddlewareModule other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Priority == other.Priority;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MiddlewareModule) obj);
        }

        public override int GetHashCode()
        {
            return Priority;
        }
    }
}