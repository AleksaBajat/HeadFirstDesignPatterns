using System;
using CommandPattern.GarageCommands;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            GarageDoor garageDoor = new GarageDoor("Garage");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
            OpenGarage openGarage = new OpenGarage(garageDoor);
            CloseGarage closeGarage = new CloseGarage(garageDoor);

            ICommand[] showFunctionality = {livingRoomLightOn, kitchenLightOn, openGarage};
            ICommand[] showFunctionalityButBackwards = {livingRoomLightOff, kitchenLightOff, closeGarage};

            MacroCommand macroCommand = new MacroCommand(showFunctionality);
            MacroCommand macroCommandOff = new MacroCommand(showFunctionalityButBackwards);
            
            remote.SetCommand(0,livingRoomLightOn,livingRoomLightOff);
            remote.SetCommand(1,kitchenLightOn,kitchenLightOff);
            remote.SetCommand(2,openGarage,closeGarage);
            remote.SetCommand(3,macroCommand,macroCommandOff);
            
            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.UndoButtonWasPushed();
            
            Console.WriteLine(remote);
            
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);
            remote.OnButtonWasPushed(3);
            remote.OffButtonWasPushed(3);
        }
    }
}