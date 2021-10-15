namespace SingletonPattern
{
    //TBD Not yet Finished!
    public class DoubleCheckLockingSingleton
    {
        private static DoubleCheckLockingSingleton _uniqueInstance;
        
        private DoubleCheckLockingSingleton(){}
        
        public static DoubleCheckLockingSingleton GetInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new DoubleCheckLockingSingleton();
            }

            return _uniqueInstance;
        }
    }
}