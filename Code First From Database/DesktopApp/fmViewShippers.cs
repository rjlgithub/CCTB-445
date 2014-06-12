using NorthwindSystem.BusinessLogicLayer;
using NorthwindSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class fmViewShippers : Form
    {
        public fmViewShippers()
        {
            InitializeComponent();
        }

        private void btnLookupShipper_Click(object sender, EventArgs e)
        {
            try
            {
                //Get data from form
                if (cboShippers.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please select a shipper.");
                }
                else
                {
                    int shipperId = Convert.ToInt32(cboShippers.SelectedValue);

                    NorthwindManager mgr = new NorthwindManager();
                    Shipper data = mgr.GetShipper(shipperId);

                    //Unpack the data
                    tboShipperID.Text = data.ShipperID.ToString();
                    tboCompanyName.Text = data.CompanyName;
                    tboPhone.Text = data.Phone;
                }
            }
            catch (Exception ex)
            {  
                //TODO: Log the exception
                MessageBox.Show("Error: " + ex.Message, "Error Loading Form", MessageBoxButtons.OK);
            }
        }

        private void btnAddShipper_Click(object sender, EventArgs e)
        {
            try
            {
                Shipper item = new Shipper()
                {
                    CompanyName = tboCompanyName.Text,
                    Phone = tboPhone.Text
                };

                var mgr = new NorthwindManager();
                item.ShipperID = mgr.AddShipper(item);
                //Give some feedback to the user...
                // - Update my combo-box
                PopulateShippersComboBox();
                // - My combo-box has the right shipper selected
                cboShippers.SelectedValue = item.ShipperID;
                // - Display the id fo the addd shipper
                tboShipperID.Text = item.ShipperID.ToString();
            }
            catch (Exception ex)
            {
                //TODO: Log the exception
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateShipper_Click(object sender, EventArgs e)
        {
            try
            {
                int shipperId;
                if (int.TryParse(tboShipperID.Text, out shipperId))
                {
                    //Do the update
                    var info = new Shipper()
                    {
                        ShipperID = shipperId,
                        CompanyName = tboCompanyName.Text,
                        Phone = tboPhone.Text
                    };

                    var mgr = new NorthwindManager();
                    mgr.UpdateShipper(info);
                    PopulateShippersComboBox();
                    cboShippers.SelectedValue = info.ShipperID;
                }

                else
                {
                    MessageBox.Show("Please lookup a shipper before trying to update.");
                }
            }
            catch (Exception ex)
            {
                //TODO: Log the exception
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteShipper_Click(object sender, EventArgs e)
        {
            try
            {
                int temp;
                if (int.TryParse(tboShipperID.Text, out temp))
                {
                    var data = new Shipper() { ShipperID = temp };
                    var mgr = new NorthwindManager();
                    mgr.DeleteShipper(data);
                    //feedback to user
                    PopulateShippersComboBox();
                    //clear the form textboxes
                    tboShipperID.Text = "";
                    tboCompanyName.Text = "";
                    tboPhone.Text = "";
                }
                else
                {
                    MessageBox.Show("Please lookup a shipper before trying to delete.");
                }
            }
            catch (Exception ex)
            {
                //TODO: Log the exception
                Program.LogMessage(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearShippersForm_Click(object sender, EventArgs e)
        {
            try
            {
                cboShippers.SelectedIndex = 0;
                tboShipperID.Text = "";
                tboCompanyName.Text = "";
                tboPhone.Text = "";
            }
            catch (Exception ex)
            {
                //TODO: Log the exception
                MessageBox.Show(ex.Message);
            }

        }

        private void fmViewShippers_Load(object sender, EventArgs e)
        {
            //Populate the ComboBox
            try
            {
                PopulateShippersComboBox();
            }
            catch (Exception ex)
            {
                //TODO: Log the exception
                MessageBox.Show("Error: " + ex.Message, "Error Loading Form", MessageBoxButtons.OK);
            }
        }

        private void PopulateShippersComboBox()
        {
            NorthwindManager manager = new NorthwindManager();
            var data = manager.ListShippers();
            //Use a 'fake' data item at top of list for the message
            data.Insert(0, new Shipper() { ShipperID = -1, CompanyName = "[Select a Shipper]" });
            cboShippers.DataSource = data;
            cboShippers.DisplayMember = "CompanyName";
            cboShippers.ValueMember = "ShipperID";
            //cboShippers.Items.Insert(0, "[Select a Shipper]");
            cboShippers.SelectedIndex = 0; //first item in the combobox
        }
    }
}
