using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23
{
    class Checkbox
    {
        private bool? Checked { get; set; }
        string description { get; set; }
        public string GetDescription()
        {

            if (Checked == null)
                description= "unassigned";
            if (Checked == false)
                description = "checked";
            if (Checked == true)
                description = "unchecked";
            return description;
        }
        public void Click()
        {
            if(Checked== null)
                Checked = true;
            else
                Checked = !Checked; //inverting/flipping value
        }
    }
}
