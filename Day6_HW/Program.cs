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
