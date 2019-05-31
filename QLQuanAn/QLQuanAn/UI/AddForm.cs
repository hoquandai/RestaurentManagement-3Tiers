
using QLQuanAn.RestBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanAn.UI
{
    public partial class AddForm : Form
    {
        public delegate void Add(RestaurentDTO rest);
        public event Add AddRest = null;
        public event Add UpdateRest = null;

        public RestaurentDTO rest = new RestaurentDTO();
        public bool update = false;

        public AddForm()
        {
            InitializeComponent();

            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (update)
            {
                btnAdd.Text = "UPDATE";
                txtName.Text = rest.Name;
                txtAddr.Text = rest.Address;
                string[] time = rest.OpenTime.Split(':');
                nOH.Value = Int32.Parse(time[0]);
                nOM.Value = Int32.Parse(time[1]);
                time = rest.CloseTime.Split(':');
                nCH.Value = Int32.Parse(time[0]);
                nCM.Value = Int32.Parse(time[1]);
                lbIDState.Visible = true;
                lbID.Text = rest.ID.ToString();
                lbID.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RestaurentDTO rest = GetRestaurentInfo();

            if (update)
            {
                if (UpdateRest != null)
                {
                    
                    UpdateRest(rest);
                }
            } else
            {
                if (AddRest != null)
                {
                    AddRest(rest);
                }
            }
            
            this.Close();
            
        }

        private RestaurentDTO GetRestaurentInfo()
        {
            RestaurentDTO rest = new RestaurentDTO();
            if (update)
            {
                rest.ID = int.Parse(lbID.Text);
            }
            rest.Name = txtName.Text;
            rest.Address = txtAddr.Text;
            string opentime = nOH.Value + ":" + nOM.Value;
           
            rest.OpenTime = opentime;
            string closetime = nCH.Value + ":" + nCM.Value;
            rest.CloseTime = closetime;

            
            return rest;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nOH_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nCM_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
