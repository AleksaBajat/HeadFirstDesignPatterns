using System;
using System.Runtime.CompilerServices;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton _uniqueInstance;
        
        private Singleton(){}
        
        public static Singleton GetInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new Singleton();
            }

            return _uniqueInstance;
        }
    }
}