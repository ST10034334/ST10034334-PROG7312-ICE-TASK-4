namespace EverydayCarry
{
    public class EVDGadget
    {
        public string gadgetName { get; set; }
        public GadgetType gadgetType { get; set; }
        public int[] dayOfWeekCarried { get; set; }


        public EVDGadget(string gadgetName, GadgetType gadgetType, int[] dayOfWeekCarried)
        {
            this.gadgetName = gadgetName;
            this.gadgetType = gadgetType;
            this.dayOfWeekCarried = dayOfWeekCarried;

        }

        public override string ToString()
        {
            return $"{gadgetName} ({gadgetType})";
        }


    }
    public enum GadgetType
    {
        Smartphone,
        Laptop,
        Smartwatch,
        Tablet,
        Bag,
        Wallet
    }
}
