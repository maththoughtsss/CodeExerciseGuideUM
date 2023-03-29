namespace CodeExercisesGuide
{
    class Program
    {
        public static void Main(string[] args)
        {
            Welcome();
        }
        static void Welcome()
        //Bienvenida y Selección
        {
            string? strProject;
            int numProject;

            Console.WriteLine("******* Bienvenido al Proyecto Guía de Ejercicios *******\n");
            Console.WriteLine("Favor ingrese el proyecto a utilizar:\n");
            Console.WriteLine(" 1.- Perímetro y Área de un Rectángulo \n 2.- Calculadora de IVA \n 3.- Mayor, Menor o Igual a 100 \n 4.- Impuestos \n 5.- Mayor que ... \n 6.- Aritmética \n 7.- Promedio \n");
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
            if(numProject == 5)
            {
                GreatherThanX();
            }
            if(numProject == 6)
            {
                Arithmetic();
            }
            if(numProject == 7)
            {
                Average();
            }
            else 
            {
                Console.Write("Presiona cualquier tecla para finalizar..."); //Bug
                Console.ReadKey(); //Bug
            }
        }        
        static void RectangleCalculator()
        //Función para calcular perímetro y área de un rectángulo.
        {   
            string? strLength, strWidth;
            double length, width, perimeter, area;

            Console.WriteLine("Cálculo del Perímetro y Área de un Rectángulo \n");
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

            Console.WriteLine("Cálculo del IVA al Valor de un Producto o Servicio \n");
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

            Console.WriteLine("Mayor, Menor o igual a 100 \n");
            Console.WriteLine("Ingrese un número entre el 0 y el 100: ");

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

            Console.WriteLine("¿Debe pagar Impuestos? \n");
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
        static void GreatherThanX()
        //Función para comparar dos enteros.
        {
            string? strNum1, strNum2;
            int num1, num2;

            Console.WriteLine("X mayor que Y \n");
            Console.WriteLine("Ingrese el primer número:");

            strNum1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo número:");
            strNum2 = Console.ReadLine();

            int.TryParse(strNum1, out num1);
            int.TryParse(strNum2, out num2);

            if (num1 > num2)        
            {
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
                Console.WriteLine($"El número {num1} es mayor que {num2}");
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
            }
            if (num1 < num2)        
            {
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
                Console.WriteLine($"El número {num2} es mayor que {num1}");
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
            }
            if (num1 == num2)        
            {
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
                Console.WriteLine($"El número {num1} es igual a {num2}, favor ingrese los números nuevamente.");
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
            }
        }
        static void Arithmetic()
        //Función para cálculo aritmético entre dos números.
        {
            string? strNum1, strNum2;
            double num1, num2, addition, subtraction, multiplication, division;

            Console.WriteLine("Aritmética \n");
            Console.WriteLine("Ingrese el primer número:");

            strNum1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo número:");
            strNum2 = Console.ReadLine();

            double.TryParse(strNum1, out num1);
            double.TryParse(strNum2, out num2);

            if (num1 > num2)        
            {
                addition = num1 + num2;
                subtraction = num1 - num2;
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
                Console.WriteLine($"El número {num1} es mayor que {num2}");
                Console.WriteLine($" Suma = {addition}\n Resta = {subtraction}");
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
            }
            if (num1 < num2)        
            {
                if(num2 == 0)
                {
                    division = 0;
                    string strDivision = "Indeterminado";
                    multiplication = num1 * num2;
                    Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
                    Console.WriteLine($"El número {num2} es mayor que {num1}");
                    Console.WriteLine($" Multiplicación = {multiplication}\n División = {strDivision}");
                    Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
                }
                else
                {
                    multiplication = num1 * num2;
                    division = num1 / num2;
                    Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
                    Console.WriteLine($"El número {num2} es mayor que {num1}");
                    Console.WriteLine($" Multiplicación = {multiplication} \n División = {division}");
                    Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
                }
            }
            if (num1 == num2)        
            {
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
                Console.WriteLine($"El número {num1} es igual a {num2}, favor ingrese los números nuevamente.");
                Console.WriteLine("++++++++++ ++++++++++ ++++++++++ ++++++++++");
            }
        }
        static void Average()
        //Función para calcular el promedio de 03 notas y entregar el estatus.
        {
            String? name, strNum1, strNum2, strNum3, status;
            double num1, num2, num3, sumScore, totalAvg; 

            //Inicio y Bienvenida del Programa
            Console.WriteLine("Bienvenido, cuál es tu nombre?: ");
            name = Console.ReadLine();

            //Input - Ingreso de Datos
            Console.WriteLine("Ingrese la primera nota: ");
            strNum1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda nota: ");
            strNum2 = Console.ReadLine();
            Console.WriteLine("Ingrese la tercera nota: ");
            strNum3 = Console.ReadLine();

            //Conversión de Datos
            double.TryParse(strNum1, out num1);
            double.TryParse(strNum2, out num2);
            double.TryParse(strNum3, out num3);

            //Suma y Promedio
            sumScore = num1 + num2 + num3;
            totalAvg = sumScore/3;

            //Sentencia
            if(totalAvg >= 6)
            {
                status = "Excelente";
            }
            else
            {
                if(totalAvg < 6 && totalAvg >= 4)
                {
                status = "Aprobado";
                }
                else
                {
                    status = "Reprobado";
                }                
            }

            //Output
            Console.Write($"Estimado {name}, su promedio es: {totalAvg}, su estatus en la asignatura es de: {status}");
        }
    }
}
