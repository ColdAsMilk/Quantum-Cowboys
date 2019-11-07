using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    class BountyPerson
    {
        private string name;
        private string wantedLevel;
        private double award;
        private string location;
        private int imageID;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string WantedLevel
        {
            get
            {
                return wantedLevel;
            }
            set
            {
                wantedLevel = value;
            }
        }
        public double Award
        {
            get
            {
                return award;
            }
            set
            {
                award = value;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public int ImageID
        {
            get
            {
                return imageID;
            }
            set
            {
                imageID = value;
            }
        }
        public BountyPerson()
        {
            name = "Billy Bob";
            wantedLevel = "Dead or Alive";
            award = 500.00;
            location = "Texas";
            imageID = 0;
        }
        public BountyPerson(string na, string wl, double aw, string lo, int id)
        {
            Name = na;
            WantedLevel = wl;
            Award = aw;
            Location = lo;
            imageID = id;
        }
    }
}
