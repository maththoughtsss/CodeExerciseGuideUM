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
            Console.WriteLine("Favor ingrese el proyecto a utilizar: \n 1.- Perímetro y Área de un Rectángulo \n 2.- Cálculador de IVA");
            strProject = Console.ReadLine();

            int.TryParse(strProject, out numProject);

            if(numProject == 1)
            {
                RectangleCalculator();
            }
            if(numProject == 2)
            {
                IVACalculator();
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

            Console.WriteLine("++++++++++ ++++++++++ ++++++++++");
            Console.WriteLine($"Perímetro: {perimeter} u");
            Console.WriteLine($"Área: {area} u2");
            Console.WriteLine("++++++++++ ++++++++++ ++++++++++");
        }
        static void IVACalculator()
        {
            string? strPrice;
            double price, iva,priceIVA, priceWithoutIVA;

            iva = 0.19;

            Console.WriteLine("Cálculo del IVA al Valor de un Producto o Servicio");
            Console.WriteLine("Ingrese el precio del producto o servicio: ");
            strPrice = Console.ReadLine();

            double.TryParse(strPrice, out price);

            priceIVA = price * iva;
            priceWithoutIVA = price - priceIVA;

            Console.WriteLine("++++++++++ ++++++++++ ++++++++++");
            Console.WriteLine($"Total Precio IVA = {priceIVA}");
            Console.WriteLine($"Total Precio Sin IVA = {priceWithoutIVA}");
            Console.WriteLine($"Total Precio = {price}");
            Console.WriteLine("++++++++++ ++++++++++ ++++++++++");
        }
    }
}