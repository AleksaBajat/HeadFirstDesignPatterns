namespace CommandPattern.GarageCommands
{
    public class OpenGarage:ICommand
    {
        private GarageDoor _door;

        public OpenGarage(GarageDoor door)
        {
            _door = door;
        }
        public void Execute()
        {
            _door.Up();
            _door.Stop();
            _door.LightOn();
        }

        public void Undo()
        {
            _door.Down();
            _door.Stop();
            _door.LightOff();
        }
    }
}