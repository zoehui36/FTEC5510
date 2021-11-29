using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class MyApplicationContext
    {
        private int formCount;
        private Form1 form1;
        private Form1 form2;

        public MyApplicationContext()
        {
            formCount = 0;

            // Create both application forms and handle the Closed event 
            // to know when both forms are closed.
            form1 = new Form1();
            form1.Closed += new EventHandler(OnFormClosed);
            formCount++;

            form2 = new Form1();
            form2.Closed += new EventHandler(OnFormClosed);
            formCount++;

            // Show both forms.
            form1.Show();
            form2.Show();
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            // When a form is closed, decrement the count of open forms. 

            // When the count gets to 0, exit the app by calling 
            // ExitThread().
            formCount--;

        }
    }
}
