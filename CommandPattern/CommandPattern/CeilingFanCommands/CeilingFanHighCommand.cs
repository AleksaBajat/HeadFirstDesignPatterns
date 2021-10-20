namespace CommandPattern.CeilingFanCommands
{
    public class CeilingFanHighCommand:ICommand
    {

        private CeilingFan _ceilingFan;
        private int _previousSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _previousSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.SetHigh();
        }

        public void Undo()
        {
            if (_previousSpeed == CeilingFan.High)
            {
                _ceilingFan.SetHigh();
            }else if (_previousSpeed == CeilingFan.Medium)
            {
                _ceilingFan.SetMedium();
            }else if (_previousSpeed == CeilingFan.Low)
            {
                _ceilingFan.SetLow();
            }else if (_previousSpeed == CeilingFan.Off)
            {
                _ceilingFan.SetOff();
            }
        }
    }
}