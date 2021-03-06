using System;

namespace Day6_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //issuing Card Builder
            DrivingLicense dl = new DrivingLicense();
            string card=dl.setName("Raneen Ayman Alzafarani")
                .setIDNumber(1023424242).setVer(1)
                .setISS()
                .setEXP()
                .setCAT("Private")
                .setNational("Saudi")
                .get();

            Console.WriteLine(card);

            /////////
            ///
            //I tried my best :") 
            Console.WriteLine("_____________________________\n");
            
            Console.Write("for \'1223321\'");
            Console.WriteLine(match2("1223321") ?" All is matched":" Not all is matched");
            Console.Write("for \'12213300877899\'");
            Console.WriteLine(match2("12213300877899") ? " All is matched" : " Not all is matched");
            Console.Write("for \'123231\'");
            Console.WriteLine(match2("123231") ? " All is matched" : " Not all is matched");
        }


        public static bool match2(string str)
        {
            string unclosed = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (unclosed.Contains(str[i]))
                {
                    int index = unclosed.IndexOf(str[i]);
                    if ((index - (i + 1)%2!=0))
                    {
                        return false;
                    }
                    unclosed = unclosed.Remove(index,1);

                }
                else
                {
                    unclosed += str[i];
                }
            }
            if (unclosed.Length == 0) return true;
            else return false;
        }

        // --------- not always right, switched to match2 function
        public static bool match(string str)
        {

            //int temp = 0;
            //123321
            //i     ->0
            // j    ->5
            
            if (str.Length % 2 != 0)
            {
                return false;
            }

            int temp = -1;
            bool unclosed = false;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                
                
                for (int j = i + 1; j < str.Length; j++)
                {

                    if (str[i] == str[j])
                    {
                        temp = j;
                        //((j % (i + 1))!=0)
                        //
                        if ((((j - (i + 1)) % 2) != 0) && (j - (i + 1)) != 0)
                        {
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("matched "+str[i]+" at "+i+" with "+str[j]+" at "+ j);
                            unclosed = true;
                            
                        }
                        count++;
                        break;
                    }
                  
                    //if it reached the end and there's no closing case for it then it's not matched
                    if ((j == (str.Length - 1)) && unclosed==false)
                    {
                        Console.WriteLine("reached end {0}=={1}",j,(str.Length-1));
                        return false;
                    }

                }
            }
            if (count == str.Length / 2) return true;
            else return false; 
        }

    }



    class DrivingLicense
    {
        private string card;
        public DrivingLicense()
        {
            this.card = "--------Driving License--------\n";
        }
        public DrivingLicense setName(string value)
        {
            this.card += "Name:  " + value;
            return this;
        }
        public DrivingLicense setIDNumber(int value)
        {
            this.card += "\nID: " + value;
            return this;
        }
        public DrivingLicense setVer(int value)
        {
            this.card += "         VER: "+value;
            return this;
        }

        public DrivingLicense setISS()
        {
            this.card += "\nISS:               " + DateTime.Now.ToString("MM/dd/yyyy");
            return this;
        }

        public DrivingLicense setEXP()
        {
            this.card += "\nEXP:               " + DateTime.Now.AddYears(10).ToString("MM/dd/yyyy");
            return this;
        }

        public DrivingLicense setCAT(string value)
        {
            this.card += "\nCAT: " + value;
            return this;
        }

        public DrivingLicense setNational(string value)
        {
            this.card += "       NAL: " + value;
            return this;
        }

public string get()
        {
            return this.card;
        }
    }
}
