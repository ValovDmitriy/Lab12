using System;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle.CircleLenght();
            Circle.CircleArea();
            Circle.PointContainsCircle();
        }

    }
    static public class Circle
    {
        static double circleRadius;
        static double circleLenght;
        static double circleArea;
        static double coordinatePointX;
        static double coordinatePointY;
        static double coordinateCircleCenterX0;
        static double coordinateCircleCenterY0;
        static double coordinateLenght;


        static public void CircleLenght()
        {
            Console.WriteLine("Вычислим длину окружности:");
            Console.Write("Введите радиус: ");
            try
            {
                circleRadius = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("Некорректно введены данные"); System.Environment.Exit(0); }
            circleLenght = Math.Round(2 * Math.PI * circleRadius, 2);
            Console.WriteLine(circleLenght);
        }
        static public void CircleArea()
        {
            Console.WriteLine("Вычислим площадь окружности:");
            Console.Write("Введите радиус: ");
            try
            {
                circleRadius = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("Некорректно введены данные"); System.Environment.Exit(0); }
            circleArea = Math.Round(Math.PI * circleRadius*circleRadius / 2, 2);
            Console.WriteLine(circleArea);
        }
        static public void PointContainsCircle()
        {
            try
            {
                Console.WriteLine("Вычислим принадлежность точки окружности:");
                Console.Write("Введите координату Х0 центра окружности: ");
                coordinateCircleCenterX0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату Y0 центра окружности: ");
                coordinateCircleCenterY0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите радиус окружности: ");
                circleRadius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату точки Х: ");
                coordinatePointX = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату точки Y: ");
                coordinatePointY = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("Некорректно введены данные"); System.Environment.Exit(0); }
            coordinateLenght = Math.Sqrt((coordinatePointX - coordinateCircleCenterX0) * (coordinatePointX - coordinateCircleCenterX0) + (coordinatePointY - coordinateCircleCenterY0) * (coordinatePointY - coordinateCircleCenterY0));
            if (coordinateLenght<=circleRadius)
            {
                Console.WriteLine("Координата ({0},{1}) принадлежит кругу",coordinatePointX,coordinatePointY);
            }
            else
            {
                Console.WriteLine("Координата ({0},{1}) не принадлежит кругу", coordinatePointX, coordinatePointY);
            }
        }

    }
}
