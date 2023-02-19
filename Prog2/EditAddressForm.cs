// Program 3
// CIS 200
// Fall 2021
// Due: 11/15/2021
// By: Mike Bergamini
// File: Prog3Form.cs
// This class lets the user choose an address object to edit and
// returns the selected index in the List of addresses
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    [Serializable] //lets data be serialized        
    
    public partial class EditAddress : Form
    {

        private List<Address> addressList;//list of addresses
        public EditAddress(List<Address> addresses)//loads list of addresses
        {
            InitializeComponent();//opens window
            addressList = addresses;
        }

        public int AddressIndex
        {
            // Precondition:  User has selected from destAddCbo
            // Postcondition: The index of the selected origin address returned
            get
            {
                return editAddressCombo.SelectedIndex;
            }

            // Precondition:  -1 <= value < addressList.Count
            // Postcondition: The specified index is selected in destAddCbo
            set
            {
                if ((value >= -1) && (value < addressList.Count))
                    editAddressCombo.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("DestinationAddressIndex", value,
                        "Index must be valid");
            }
        }
        //Procondition: Cancel Button Clicked
        //Postcondition: window closed
        private void CancelEditAddress_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }               
       
        //Precondition: Ok button clicked
        //Postcondition: THIS selected index is sent to the edit address form
        private void OkEditAddress_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //Precondtion: edit address form is loaded
        //Postcondition: Name properties of address objects loaded into combobox
        private void EditAddress_Load(object sender, EventArgs e)
        {
            foreach (Address a in addressList)
            {
                editAddressCombo.Items.Add(a.Name);
            }
        }
    }
    
}
