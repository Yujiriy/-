using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poimorfizm
{
    // Abstract class "Product"
    interface IBuilding
    {
        string Address { get; set; }
        int YearBuilt { get; set; }

        string DisplayInformation();
    }

    // Abstract class PublicBuilding implementing the IBuilding interface
    abstract class PublicBuilding : IBuilding
    {
        public string Address { get; set; }
        public int YearBuilt { get; set; }

        public abstract string DisplayInformation();
    }

    // Theater class, inherits from PublicBuilding
    class Theater : PublicBuilding
    {
        public string Name { get; set; }

        public override string DisplayInformation()
        {
            return "Theater Information:" + Environment.NewLine +
                            "Address: " + Address + Environment.NewLine +
                            "Year Built: " + YearBuilt + Environment.NewLine +
                            "Name: " + Name;
        }
    }

    // Museum class, inherits from PublicBuilding
    class Museum : PublicBuilding
    {
        public string Name { get; set; }

        public override string DisplayInformation()
        {
            return "Museum Information:" + Environment.NewLine +
                            "Address: " + Address + Environment.NewLine +
                            "Year Built: " + YearBuilt + Environment.NewLine +
                            "Name: " + Name;
        }
    }
}
