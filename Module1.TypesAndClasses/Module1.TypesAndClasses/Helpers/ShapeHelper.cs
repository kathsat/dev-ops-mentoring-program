﻿using Module1.TypesAndClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module1.TypesAndClasses.Helpers
{
    static class ShapeHelper
    {
        public static bool PerimeterEquals(IShape shape1, IShape shape2)
        {
            //IShape objectShape = obj as IShape;

            //if (shape1 == null || shape2 == null) return false;
            //if (shape1 == null && shape2 == null) return false;
            if (shape1 == null)
            {
                if (shape2 == null)
                {
                    throw new ArgumentNullException("Objects shape1 and shape2 were null.");
                }

                throw new ArgumentNullException(nameof(shape1));
            }

            if (shape2 == null)
            {
                throw new ArgumentNullException(nameof(shape2));
            }

            return shape1.Perimeter() == shape2.Perimeter();
        }

        public static bool SquareEquals(IShape shape1, IShape shape2)
        {
            if (shape1 == null)
            {
                if (shape2 == null)
                {
                    throw new ArgumentNullException("Objects shape1 and shape2 were null.");
                }

                throw new ArgumentNullException(nameof(shape1));
            }

            if (shape2 == null)
            {
                throw new ArgumentNullException(nameof(shape2));
            }

            return shape1.Square() == shape2.Square();
        }
    }
}
