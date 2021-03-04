
namespace Assignment_4
{
    public class TShirt
    {
        public Color Color;
        public Size Size;
        public Fabric Fabric;
        public decimal Price { get; set; }

        public TShirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        public void Output()
        {
            System.Console.WriteLine($"{Size,-15}{Color,-15}{Fabric,-15}");
        }



    }

}
