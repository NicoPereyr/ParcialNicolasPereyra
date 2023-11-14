using System;

namespace WinFormsTP.Entidades
{
    public class Rectangulo : ICloneable
    {
        public int Radio { get; set; }
        public string Color { get; set; }
        public string Borde { get; set; }

        public Rectangulo(int area, string borde, string color)
        {
            Radio = area;
            Borde= borde;
            Color = color;
        }
        public double GetRadio() => Radio;
        public void SetArea(int medidaArea)
        {
            if (medidaArea > 0)
            {
                Radio = medidaArea;
            }
        }
        public string GetBorde() => Borde;
        public void SetBorde(string borde)
        {
            {
                borde = Borde;
            }
        }

        public string GetColor() => Color;
        public void SetColor(string color)
        {
            {
                color = Color;
            }
        }

        public double GetArea() => (4)*Math.PI*Math.Pow(Radio,2);
        public double GetVolumen() => (4.0/3.0)*Math.PI*Math.Pow(Radio,3);

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
