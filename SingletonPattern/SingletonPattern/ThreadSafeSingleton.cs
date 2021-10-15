namespace SingletonPattern
{
    //TBD Not yet Finished!
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _uniqueInstance;
        
        private ThreadSafeSingleton(){}
        
        public static ThreadSafeSingleton GetInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new ThreadSafeSingleton();
            }

            return _uniqueInstance;
        }
    }
}