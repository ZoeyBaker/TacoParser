using System;


namespace LoggingKata
{
    public class tacoBell : tacoBellBase, ITrackable
    {
        public tacoBell()
        {

        }
        public string Name { get; set; }
    }
}
