﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PhysicLibrary
{
    public class Ray
    {
        public Vector3 origin;
        public Vector3 direction;

        public Ray()
        {
        }

        public Ray(Vector3 origin, Vector3 direction)
        {
            this.origin = origin;
            this.direction = direction;
        }
    }
}
