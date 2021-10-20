namespace CommandPattern.GarageCommands
{
    public class CloseGarage:ICommand
    {
        private GarageDoor _door;

        public CloseGarage(GarageDoor door)
        {
            _door = door;
        }
        public void Execute()
        {
            _door.Down();
            _door.Stop();
            _door.LightOff();
        }

        public void Undo()
        {
            _door.Up();
            _door.Stop();
            _door.LightOn();
        }
    }
}