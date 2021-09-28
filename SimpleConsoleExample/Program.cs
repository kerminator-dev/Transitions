using System;
using TransitionsLibrary.Models;
using static TransitionsLibrary.Models.Functions.Easings;

namespace SimpleConsoleExample
{
    class Program
    {
        static ValueTransition Transition;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Transition = new ValueTransition
            (
                startValue: 0,
                endValue: 70,
                duration: 4000,
                onValueChanged: OnValueChanged,
                easingFunction: Elastic.InOut,
                targetControl: null,
                fps: 25
            );
            Transition.OnTransitionStart = OnStart;
            Transition.OnTransitionEnd = OnEnd;

            Transition.Start();
        }
        static void OnStart()
        {
            Console.Clear();
            Console.WriteLine("Transition initialized. Press any key to start");
            Console.ReadLine();
        }

        static void OnEnd()
        {
            Console.WriteLine("Transition ends");
            Console.ReadLine();
            Transition.Start();
        }

        static void OnValueChanged(float value, object control)
        {
            Console.Clear();
            string a = $"Value: {value} ({(value * 100) / Transition.EndValue}%)\n";
            for (int i = 0; i < value; i++)
            {
                a += "#";
            }
            Console.WriteLine(a);
        }
    }
}
