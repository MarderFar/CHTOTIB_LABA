using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    class Person
    {
        public string FirstName
        {
            get;set;
        }
        public string SecondName
        {
            get;set;
        }
        public int Age 
        {
            get;set;
        }
        public void SetAge(DateTime bithday)
        {
            Age = Convert.ToInt32(DateTime.Now.Subtract(bithday).Days/365.25);
        }
    }
}
