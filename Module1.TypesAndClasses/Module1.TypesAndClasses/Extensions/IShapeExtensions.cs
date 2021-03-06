﻿using Module1.TypesAndClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module1.TypesAndClasses.Extensions
{
    public static class IShapeExtensions
    {
        public static bool PerimeterEquals(this IShape shape, IShape other)
        {
            if (shape == null)
            {
                throw new ArgumentNullException(nameof(shape));
            }

            if (other == null)
            {
                return false;
            }

            return shape.Perimeter() == other.Perimeter();
        }
    }
}
