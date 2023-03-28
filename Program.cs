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

            Console.WriteLine("******* Bienvenido al Proyecto Guía de Ejercicios *******\n");
            Console.WriteLine("Favor ingrese el proyecto a utilizar: \n 1.- Perímetro y Área de un Rectángulo \n 2.- Calculadora de IVA \n 3.- Mayor, Menor o Igual a 100 \n 4.- Impuestos");
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
            if(numProject == 3)
            {
                GreaterOrLessThanOneHundred();
            }
            if(numProject == 4)
            {
                Taxes();
            }
            else {
                Console.WriteLine("Proyecto No Encontrado, Intente Nuevamente.");
            }
        }        
        static void RectangleCalculator()
        //Función para calcular perímetro y área de un rectángulo.
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
        //Función para calcular el IVA del precio de un producto o servicio.
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
            Console.WriteLine($"Total Precio IVA = $ {priceIVA}");
            Console.WriteLine($"Total Precio Sin IVA = $ {priceWithoutIVA}");
            Console.WriteLine($"Total Precio = $ {price}");
            Console.WriteLine("++++++++++ ++++++++++ ++++++++++");
        }

        static void GreaterOrLessThanOneHundred()
        //Función para comparar un número x con 100 y evaluar si es mayor, menor o igual.
        {
            string? strNum;
            int Num;

            Console.WriteLine("Mayor, Menor o igual a 100");
            Console.WriteLine("Ingrese un nùmero entre el 0 y el 100: ");

            strNum = Console.ReadLine();
            int.TryParse(strNum, out Num);

            if(Num < 100)
            {   
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++");
                Console.WriteLine($"El número {Num} es menor que 100");
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++");
            }
            if(Num > 100)
            {
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++");
                Console.WriteLine($"El número {Num} es mayor a 100");
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++");
            }
            if(Num == 100)   
            {
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++");
                Console.WriteLine($"El número {Num} es igual a 100");
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++");
            }
        }
        static void Taxes()
        //Función para calcular si se debe o no pagar impuestos.
        {
            string? strIncome;
            int income, minIncome;

            minIncome = 800000;

            Console.WriteLine("¿Debe pagar Impuestos?");
            Console.WriteLine("Ingrese su remuneración:");

            strIncome = Console.ReadLine();
            int.TryParse(strIncome, out income);

            if(income > minIncome)
            {
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++");
                Console.WriteLine($"Debido al monto de su remuneración, a usted le corresponde pagar impuestos.");
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++");
            }
            else
            {
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++");
                Console.WriteLine($"Debido al monto de su remuneración, a usted NO le corresponde pagar impuestos.");
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++ ++++++++++");
            }
        }
    }
}
