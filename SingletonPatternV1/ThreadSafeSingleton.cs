using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternV1
{
    public class ThreadSafeSingleton
    {
        private ThreadSafeSingleton() { }

        private static ThreadSafeSingleton _instance;

        // We now have a lock object that will be used to synchronize threads
        // during first access to the Singleton.
        private static readonly object _lock = new();

        public static ThreadSafeSingleton GetInstance(string value)
        {
            if (_instance == null)
            {
              
                lock (_lock)
                {
                  
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        // We'll use this property to prove that our Singleton really works.
        public string Value { get; set; }
    }
}
