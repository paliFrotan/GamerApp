namespace GamerService.Models
{
    public class Wheel
    {
        public bool IsPumpedUp { get; private set; }
        public Wheel() 
        { 

        }
        public void PumpedUpTyre()
        {
            IsPumpedUp = true;
        }
    }
}
