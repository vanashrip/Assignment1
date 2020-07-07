using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignments
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public class StudentModel

        { }

            public string Full_Name { get; set; }

            public int ClassRoom { get; set; }

            public string Teacher_Name { get; set; }

            public string Principle_Name { get; set; }

            public string School_Name { get; set; }

            public string Documents { get; set; }
 

        }
    }
}
