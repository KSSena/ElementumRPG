using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public static class Dice
    {
        public static int Random(int max){
            Random dice = new Random();
            return dice.Next(max);
        }

        public static int Bonus(int attribute){
            Random dice = new Random();
            double value = (dice.Next(attribute))/10;
            return Convert.ToInt32(Math.Round(value , MidpointRounding.AwayFromZero));
        }


        public static int D20(){
            Random dice = new Random();
            return dice.Next(1, 20);
        }

        public static int D20(int attribute){
            Random dice = new Random();
            double value = (dice.Next(200) + attribute)/10;
            int result = Convert.ToInt32(Math.Round(value , MidpointRounding.AwayFromZero));
            if(result > 20) result = 20;
            else if(result <= 0) result = 1;
            return result;
        }
    }
}