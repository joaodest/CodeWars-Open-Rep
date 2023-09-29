using InterfacesEX1.Model.Enums;

namespace InterfacesEX1.Model.Entities {
    internal class Circle : AbstractShape {

        
        public double Radius { get; set; }

        public override double Area() {
            return Radius * Radius * Math.PI;
        }

        public override string ToString() {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2")
                + ", area = "
                + Area().ToString("F2");
        }
    }
}
