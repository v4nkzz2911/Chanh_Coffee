using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanh_Coffee.View.AdminForms
{
    interface Interface1
    {
        bool ShouldKeepForm { get; set; }
        void OnMounted();
        //void OnUnMounted(ref UserControl next);
    }
}
