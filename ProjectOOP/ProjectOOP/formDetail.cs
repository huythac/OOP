using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class formChiTiet : Form
    {
        Data data = new Data();
        public formChiTiet()
        {
            InitializeComponent();

        }
        private void formChiTiet_Load(object sender, EventArgs e)
        {
            //Định nghĩa 4 cột của listView
            lstHangHoa.Columns[0].Width =(int)(lstHangHoa.Width * 0.25);
            lstHangHoa.Columns[1].Width =(int)(lstHangHoa.Width * 0.25);
            lstHangHoa.Columns[2].Width =(int)(lstHangHoa.Width * 0.25);
            lstHangHoa.Columns[3].Width =(int)(lstHangHoa.Width * 0.25);
        }
    }
}
