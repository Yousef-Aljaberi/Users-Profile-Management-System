using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UsersPorfile_Management_System
{
    public class UserProfile
    {

        public string ID { get; set; }
        public string FullName { get; set; }
        public string Deparment { get; set; }
        public string PhoneNumber { get; set; }
        public Image image { get; set; }

        public override string ToString( )
        {
            return $"{FullName} -({Deparment})- {PhoneNumber}";
        }

    }
}
