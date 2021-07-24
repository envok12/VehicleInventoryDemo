using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VheicleInventory
{
    public partial class VehicleInventoryForm: UserControl
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        public VehicleInventoryForm()
        {
            InitializeComponent();
            inventoryListBox.DataSource = vehicles;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(cbType.Text.Equals("Sedan"))
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = licensePlateTextBox.Text;
                sedan.VIN = VINTextBox.Text;
                vehicles.Add(sedan);
                //Refresh the list box
                inventoryListBox.DataSource = null;
                inventoryListBox.DataSource = vehicles;
                inventorySummaryTextBox.Text = "Successfuly added sedan";

            }
            else
            {
                Truck truck = new Truck(VINTextBox.Text, licensePlateTextBox.Text);
                vehicles.Add(truck);
                //Refresh the list box
                inventoryListBox.DataSource = null;
                inventoryListBox.DataSource = vehicles;
                inventorySummaryTextBox.Text = "Successfuly added truck";
               
            }
        }
    }
}
