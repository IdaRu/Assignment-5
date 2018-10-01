using System;

namespace Assignment_3
{
    public class PlayerException : Exception
    {
        public PlayerException():base ("Too low power")
        {
            
        }
    }
}