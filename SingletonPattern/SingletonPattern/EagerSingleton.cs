namespace SingletonPattern
{
    public class EagerSingleton
    {
        //This will make singleton thread safe because we initialise the instance before the GetInstance() method
        private static EagerSingleton _uniqueInstance = new EagerSingleton();
        
        private EagerSingleton(){}
        
        public static EagerSingleton GetInstance()
        {
            return _uniqueInstance;
        }
    }
}