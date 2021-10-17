namespace CommandPattern
{
    public class LightOnCommand:ICommand
    {
        private Light _light;
        
        public void Execute()
        {
            _light.On();
        }

        public LightOnCommand(Light light)
        {
            _light = light;
        }
    }
}