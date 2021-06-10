using System;

namespace ClassFixture
{
    public class RandomNumberGenerator
    {
        public int RandomNumber { get; set; } = new Random().Next(0, 100000);
    }
}
