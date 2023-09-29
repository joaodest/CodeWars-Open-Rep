﻿

using InterfacesEX1.Model.Enums;

namespace InterfacesEX1.Model.Entities {
    abstract class AbstractShape : IShape{
        public Color Color { get; set; }

        public abstract double Area();
    }
}
