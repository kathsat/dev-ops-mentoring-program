﻿using log4net;
using Mentoring.Shapes.Interfaces;
using Module1.TypesAndClasses.Exceptions;
using Module1.TypesAndClasses.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Module1.TypesAndClasses.Pools
{
    public class ShapeServicePool
    {
        private readonly IEnumerable<IShapesService> _shapesServices;
        private readonly ILog _log;

        public ShapeServicePool(IEnumerable<IShapesService> shapesServices,ILog log)
        {
            _shapesServices = shapesServices ?? throw new ArgumentNullException(nameof(shapesServices));
            _log = log ?? throw new ArgumentNullException();
        }

        public IShapesService Create(ShapeTypes shapeType)
        {
            _log.Info($"running shapetype {shapeType}...");

            switch (shapeType)
            {
                case ShapeTypes.EquilateralTriangle:
                    {
                        return _shapesServices.Single(c => c.Name == nameof(TriangleService));
                    }
                case ShapeTypes.Circle:
                    {
                        return _shapesServices.Single(c => c.Name == nameof(CircleService));
                    }
                case ShapeTypes.Rectangle:
                    {
                        return _shapesServices.Single(c => c.Name == nameof(RectangleService));
                    }
                case ShapeTypes.Ellipse:
                    {
                        return _shapesServices.Single(c => c.Name == nameof(EllipseService));
                    }
                default:
                    {
                        _log.Error($"This method {shapeType} is invalid or not implemented yet");
                        throw new MethodNotImplementedException($"This method {shapeType} is invalid or not implemented yet"); ;
                    }
            }
        }
    }
}