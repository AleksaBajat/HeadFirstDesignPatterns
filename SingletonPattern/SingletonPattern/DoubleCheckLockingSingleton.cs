namespace SingletonPattern
{
    //TBD Not yet Finished!
    public class DoubleCheckLockingSingleton
    {
        private static volatile DoubleCheckLockingSingleton _uniqueInstance;
        private static readonly object BalanceLock = new object();
        
        private DoubleCheckLockingSingleton(){}
        
        public static DoubleCheckLockingSingleton GetInstance()
        {
            if (_uniqueInstance == null)
            {
                lock (BalanceLock)
                {
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new DoubleCheckLockingSingleton();
                    }

                    return _uniqueInstance;
                }
            }

            return _uniqueInstance;

        }
    }
}