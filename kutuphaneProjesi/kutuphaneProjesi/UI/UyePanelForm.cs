using kutuphaneProjesi.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneProjesi.UI
{
    public partial class UyePanelForm : Form
    {
        uyelerDAL uDal = new uyelerDAL();
        int aktifUyeId; 

        public UyePanelForm(int uyeId)
        {
            InitializeComponent();
            aktifUyeId = uyeId;
        }

        private void UyePanelForm_Load(object sender, EventArgs e)
        {
             dgvGecmis.DataSource = uDal.UyeGecmisiGetir(aktifUyeId);
                lblToplamOkunan.Text = dgvGecmis.Rows.Count.ToString();
          
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
