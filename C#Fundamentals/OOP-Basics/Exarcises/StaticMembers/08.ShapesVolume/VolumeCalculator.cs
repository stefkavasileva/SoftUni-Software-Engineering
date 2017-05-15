using System;

namespace _08.ShapesVolume
{
    public static class VolumeCalculator
    {
        public static double GetVolume(TriangularPrism triangular)
        {
            return (1.0 / 2.0) * triangular.lenght * triangular.baseSide * triangular.height;
        }

        public static double GetVolume(Cube cube)
        {
            return Math.Pow(cube.sideLenght, 3);
        }

        public static double GetVolume(Cylinder cylinder)
        {
            return Math.PI * cylinder.radius * cylinder.radius * cylinder.height;
        }
    }
}
