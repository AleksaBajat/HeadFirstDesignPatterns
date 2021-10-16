namespace SingletonPattern
{
    //TBD Not yet Finished!
    public class ThreadSafeSingleton
    {
        private static readonly object BalanceLock = new object();
        private static ThreadSafeSingleton _uniqueInstance;

        private ThreadSafeSingleton(){}
        
        public static ThreadSafeSingleton GetInstance()
        {
            lock (BalanceLock)
            {
                if (_uniqueInstance == null)
                {
                    _uniqueInstance = new ThreadSafeSingleton();
                }    
            }
            return _uniqueInstance;
        }
        
        //Could be written using a property just 
        // Instance { get{ same code } }
    }
}