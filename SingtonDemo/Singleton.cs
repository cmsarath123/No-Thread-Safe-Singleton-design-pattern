using System;
using System.Collections.Generic;
using System.Text;

namespace SingtonDemo
{
    public class Singleton
    {
        private static int ObjectsCount = 0;
        public static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        private Singleton()
        {
            ObjectsCount++;
            Console.WriteLine($"instance created and the count is {ObjectsCount}");
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
