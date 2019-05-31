using QLQuanAn.RestBUS;
using QLQuanAn.UI;
using System;
using System.Windows.Forms;

namespace QLQuanAn
{
    public partial class QLQuanAn : Form
    {

        RestaurentSoapClient restWS = 
            new RestaurentSoapClient();

        public QLQuanAn()
        {
            InitializeComponent();
        }

        private void QLQuanAn_Load(object sender, EventArgs e)
        {
            gvRest.DataSource = restWS.readAll().Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.AddRest += AddForm_AddRest;
            this.Hide();
            addForm.ShowDialog();
            this.Show();
            
        }

        private void AddForm_AddRest(RestaurentDTO rest)
        {
            restWS.insert(rest);
            gvRest.DataSource = restWS.readAll().Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvRest.SelectedRows.Count > 0) {
                DataGridViewRow row = gvRest.SelectedRows[0];
                DialogResult result = MessageBox.Show("Are you sure to delete this record?", "DELETE",
                    MessageBoxButtons.YesNo);
                if (DialogResult.Yes == result)
                {
                    restWS.delete((int)row.Cells[0].Value);
                }

                gvRest.DataSource = restWS.readAll().Tables[0];
            }
               else
            {
                MessageBox.Show("No rows has been selected yet!\nSelect row not cell!");
            }
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gvRest.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gvRest.SelectedRows[0];
                AddForm updateFrm = new AddForm();
                updateFrm.update = true;
                

                updateFrm.rest.ID = (int)row.Cells[0].Value;
                updateFrm.rest.Name = (string)row.Cells[1].Value;
                updateFrm.rest.Address = (string)row.Cells[2].Value;
                updateFrm.rest.OpenTime = (string)row.Cells[3].Value;
                updateFrm.rest.CloseTime = (string)row.Cells[4].Value;
                updateFrm.UpdateRest += UpdateFrm_UpdateRest;
                this.Hide();
                updateFrm.ShowDialog();
                
                this.Show();
            }
            else
            {
                MessageBox.Show("No rows has been selected yet\nSelect row not cell!");
            }
        }

        private void UpdateFrm_UpdateRest(RestaurentDTO rest)
        {
           
            restWS.update(rest);
            gvRest.DataSource = restWS.readAll().Tables[0];
        }
    }
}
