﻿using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();

            Light light = new Light();

            LightOnCommand lightOn = new LightOnCommand(light);
            
            remote.SetCommand(lightOn);
            light.CheckState();
            remote.ButtonPressed();
            light.CheckState();
        }
    }
}