namespace CodeExercisesGuide
{
    class Program
    {
        public static void Main(string[] args)
        {
            Welcome();
        }
        static void Welcome()
        {
            string? strProject;
            int numProject;

            Console.WriteLine("******* Bienvenido al Proyecto Guía de Ejercicios *******");
            Console.WriteLine("Favor ingrese el proyecto a utilizar: \n \n 1.- Perímetro y Área de un Rectángulo");
            strProject = Console.ReadLine();

            int.TryParse(strProject, out numProject);

            if(numProject == 1)
            {
                RectangleCalculator();
            }
            else {
                Console.WriteLine("Proyecto No Encontrado, Intente Nuevamente.");
            }
        }        
        static void RectangleCalculator() 
        {   
            string? strLength, strWidth;
            double length, width, perimeter, area;

            Console.WriteLine("Cálculo del Perímetro y Área de un Rectángulo");
            Console.WriteLine("Favor ingrese la longitud del ancho:");
            strLength = Console.ReadLine();
            Console.WriteLine("Favor ingrese la longitud del largo:");
            strWidth = Console.ReadLine();

            double.TryParse(strLength, out length);
            double.TryParse(strWidth, out width);

            perimeter = 2*length + 2*width;
            area = length * width;

            Console.WriteLine($"Perímetro: {perimeter} u");
            Console.WriteLine($"Área: {area} u2");
        }
    }
}