using System;
using System.Collections.Generic;
using System.Text;

namespace MotorVehicles
{
    public abstract class Vehicle
    {

        public string Model { get; set; }
        public int TopSpeed { get; set; }
        public int WheeleSize { get; set; }

        private int _currentSpeed;
        public int CurrentSpeed
        {
            get
            {
                return _currentSpeed;
            }
            set
            {
                _currentSpeed = value;
            }
        }


        public Vehicle()
        {
            /*
                Initialization Code
             */

            Model = "Mini";
            CurrentSpeed = 10;
            TopSpeed = 235;
        }


        public void Accelerate(int accValue)
        {
            // readable way
            int newSpeed = CurrentSpeed + accValue;
            CurrentSpeed = newSpeed;

            // shorter
            CurrentSpeed += accValue;
        }

        public void Brake()
        {
            CurrentSpeed = 0;

        }
    }
}
