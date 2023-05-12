using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS12thProject
{
    public partial class Available : Form
    {
        public static Available Instance;
        public int[] available;

        public Available()
        {
            Instance = this;

            InitializeComponent();
        }
    }
}
