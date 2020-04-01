using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Korespondent
    {
        public string MailAddress { get; set; }
        public string Name { get; set; }

        public string FullName
        {
            get
            {
                return Name + " " + MailAddress;
            }
        }
    }
}
