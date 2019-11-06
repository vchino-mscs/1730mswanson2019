namespace mswanson2g1
{
    public class Ex2gCalculations
    {
        public static string Switch01(string costumerType)
        {
            //1a) 'Switch' with no default
            decimal discountPercent = -1m;
            switch (costumerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }

        public static string If01(string costumerType)
        {
            //1b) Separate 'if' statements
            decimal discountPercent = -1m;
            if (costumerType == "R")
                discountPercent = .1m;
            if (costumerType == "C")
                discountPercent = .2m;
            return discountPercent.ToString("0.0");
        }

        public static string ElseIf01(string costumerType)
        {
            //1c) If else if
            decimal discountPercent = -1m;
            if (costumerType == "R")
                discountPercent = .1m;
            else if (costumerType == "C")
                discountPercent = .2m;
            return discountPercent.ToString("0.0");
        }

        public static string NestedIfElse01(string costumerType)
        {
            //1d) Nested if else
            decimal discountPercent = -1m;

            if (costumerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (costumerType == "C")
                {
                    discountPercent = .2m;
                }
            }
            return discountPercent.ToString("0.0");
        }

        public static string SwitchDefault01(string costumerType)
        {
            //1e) 'Switch' with default
            decimal discountPercent = -1m;
            switch (costumerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
                default:
                    discountPercent = .0m;
                    break;

            }
            return discountPercent.ToString("0.0");
        }

        public static string IfDefault01(string costumerType)
        {
            //1f) Separate 'if' statements, default value 0
            decimal discountPercent = -1m;
            if (costumerType == "R")
                discountPercent = .1m;
            if (costumerType == "C")
                discountPercent = .2m;
            if (costumerType != "R" && costumerType != "C")
                discountPercent = .0m;

            return discountPercent.ToString("0.0");
        }

        public static string ElseIfDefault01(string costumerType)
        {
            //1g) If else if with default
            decimal discountPercent = -1m;
            if (costumerType == "R")
                discountPercent = .1m;
            else if (costumerType == "C")
                discountPercent = .2m;
            else
                discountPercent = .0m;

            return discountPercent.ToString("0.0");
        }

        public static string NestedIfElseDefault01(string costumerType)
        {
            //1h) Nested if-else with default
            decimal discountPercent = -1m;

            if (costumerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (costumerType == "C")
                {
                    discountPercent = .2m;
                }
                else
                {
                    discountPercent = .0m;
                }
            }
            return discountPercent.ToString("0.0");
        }

        public static string Switch02(string costumerType)
        {
            // 2a) 'Switch' with no default
            decimal discountPercent = -1m;

            switch (costumerType)
            {
                case "R":
                case "C":
                    discountPercent =.2m;
                    break;
                case "T":
                    discountPercent = .4m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }  

        
        public static string If02(string costumerType)
        {
            // 2b) Separate 'if' statements

                decimal discountPercent = -1m;
            if (costumerType == "R")
                discountPercent = .2m;
            
            if (costumerType == "C")
             discountPercent = .2m;
            
            if (costumerType == "T")
            discountPercent = .4m;
            
            return discountPercent.ToString("0.0");
        }

        public static string ElseIf02(string costumerType)
        {
            // 2c) if elseif

            decimal discountPercent = -1m;
            if (costumerType == "R")
            discountPercent = .2m;
            else if (costumerType == "C")
            discountPercent = .2m;
            else if (costumerType == "T")
            discountPercent = .4m;

            return discountPercent.ToString("0.0");
        }


           
        public static string NestedIfElse02(string costumerType)

        {
            // 2d) Nested if-else
            decimal discountPercent = -1m;

            if (costumerType == "R" || costumerType == "C")
            {
                discountPercent = .2m;
            }
            else
            {
                if (costumerType == "T")
                {
                discountPercent = .4m;
                }
            
            }
            return discountPercent.ToString("0.0");
        }


            }  
            
        }
    
