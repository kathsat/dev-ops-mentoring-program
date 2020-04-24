﻿using Module1.TypesAndClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module1.TypesAndClasses.Shapes
{
    public abstract class AbstractShape
    {
        protected double Convert(Units target, double targetValue) {
            switch (target)
            {
                case Units.centimeter:
                    return targetValue / 100;
                case Units.millimeter:
                    return targetValue / 1000;
                default:
                    return targetValue;

            }
                
        }

    }
}