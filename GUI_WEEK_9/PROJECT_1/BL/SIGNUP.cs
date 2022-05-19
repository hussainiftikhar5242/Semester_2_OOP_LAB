using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BL
{
    class SIGNUP
    {
        private string Name;
        private string Password;
        public SIGNUP(string Name,string Password)
        {
            this.Name1 = Name;
            this.Password1 = Password; 
        }

        public string Name1 { get => Name; set => Name = value; }
        public string Password1 { get => Password; set => Password = value; }
    }
}
