namespace EXERC_03
{
    public class ResultData
    {
        private double areaCirculo;
        private double areaQuadrado;
        private double perimetroTriangulo;
        private double areaTriangulo;
        private double areaTrianguloCoord;
        private string usoIncorreto = "Uso Incorreto!";


        public double AreaCirculo { get { return areaCirculo; } set { areaCirculo = value; } }
        public double AreaQuadradoRetangulo { get { return areaQuadrado; } set { areaQuadrado = value; } }
        public double PerimetroTriangulo { get { return perimetroTriangulo; } set { perimetroTriangulo = value; } }
        public double AreaTriangulo { get { return areaTriangulo; } set { areaTriangulo = value; } }
        public double AreaTrianguloCoord { get { return areaTrianguloCoord; } set { areaTrianguloCoord = value; } }
        public string UsoIncorreto { get { return usoIncorreto; } set { usoIncorreto = value; } }

    }
}