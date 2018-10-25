namespace ENCAPSULATION
{
    using System;
    using System.Text;

    public class Box
    {
        
        public Box(double lenght,double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public double Lenght { get; set; }

        private double CalcArea()
        {
            return (2 * this.Lenght * this.Width) + (2 * this.Lenght * this.Height) + (2 * this.Height * this.Width);
        }

        private double CalcLateralArea()
        {
            return (2 * this.Lenght * this.Height) + (2 * this.Height * this.Width);
        }

        private double CalcVolume()
        {
            return this.Height * this.Width * this.Lenght;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine($"Surface Area – {CalcArea():f2}");
            sb.AppendLine($"Lateral Surface Area – {CalcLateralArea():f2}");
            sb.AppendLine($"Volume – {CalcVolume():f2}");

            return sb.ToString();
        }
    }
}
