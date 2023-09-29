﻿using InterfacesEX1.Model.Enums;

namespace InterfacesEX1.Model.Entities {
     class Rectangle : AbstractShape {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area() {
            return Width * Height;
        }

        public override string ToString() {
            return "Rectangle color = "
                + Color
                + ", width = "
                + Width.ToString("F2")
                + ", height = "
                + Height.ToString("F2")
                + ", area = "
                + Area().ToString("F2");
        }
    }
}
