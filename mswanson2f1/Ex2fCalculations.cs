using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mswanson2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            //#1: if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
            discountPercent = 0.2m;
            return discountPercent.ToString("n2");

            }
        public static string Calc02(string input)
        {
            //#2 if (block)
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            discountPercent = 0m;
            subtotal = decimal.Parse(input);
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            //#3 if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");

        }

        public static string Calc04(string input)
        {
            //#4 if else if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m && subtotal < 200m)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");

        }

        public static string Calc05(string input)
        {
            //#5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(inputA);
            string costumerType = inputB;
            discountPercent = 0m;

            if (costumerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else discountPercent = 0.1m;
            }
            else // costumerType isn't "R"
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            
            // #7 Validate input: non-empty string

            decimal ethereum = 0m;
            decimal dollars = Decimal.Parse(input);


            if (input != "")
            {
             if (dollars >= 100.00m)
                 ethereum = 200 * dollars;
                return ethereum.ToString("n2");
            }

            else if (input == "")
                return "Invalid input";

        }

        public static string Calc08(string inputA, string inputB)
        {

            // #8 Validate input, calculate quantity * price, shipping4
            decimal total = 0m;
            decimal Price = Decimal.Parse(inputA);
            int Quanity = Convert.ToInt32(inputB);


            if (inputA != "" && inputB != "")
            {
                if (Price >= 25.00m && Quanity >= 2.00m)
                    total = Price * Quanity;
                return total.ToString("n2");
            }

            else if (Price <= 24.99m && Quanity >= 2.00m)
                total = Price * Quanity + 5.00m;
            return total.ToString("n2");

            else if (inputA == "25.00" && inputB == "")
                return "Invalid input";

            return total.ToString("n2");


        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            

        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0

            decimal total = 0m;
            int large = Convert.ToInt32(inputB);
            int small = Convert.ToInt32(inputA);

            if ( large > 4m &&  small > 2m)

            {
                total = large / small;
                return total.ToString("2n");
            }

            if (large = 2m && small = 4m)
            return "Invalid input";

        }

    }
}
