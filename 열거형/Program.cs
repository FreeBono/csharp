using System;

// flags를 쓰는 이유는 고유의 속성을 묶어서 "속성묶음"을 만들어서 고유의 속성이 "속성묶음"에 있는지 확일 할 때 많이 씁니다.



namespace EnumTest 
{
    class Program
    {
        enum Item
        {
            Coffee = 1,
            Tea,
            IceCream,
            Bread
        }

        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left =8 
        }

        static void Main(string[] args)
        {
            Order(Item.Tea,3);

            Border b = Border.Top | Border.Bottom; // or을 사용하면 다중 플래그

            if (b & Border.Top != 0)
            {

            }
        }

        static void Order(Item item, int qty)
        {
            switch (item)
            {
                case Item.Coffee:
                    // Make Coffee
                    break;
                case Item.Tea:
                    // Make Tea
                    break;
                case Item.IceCream:
                    // Scoop IceCream
                    break;
                case Item.Bread:
                    // Bake Bread & Serve
                    break;
                default:
                    break;
            }
        }
    }
}
