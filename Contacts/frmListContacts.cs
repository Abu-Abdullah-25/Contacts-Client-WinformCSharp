using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ContactApiClient.DTOs;

namespace ContactApiClient
{
    public partial class frmListContacts : Form
    {
        //static readonly HttpClient httpClient = new HttpClient();
        private static List<Contact> _AllContacts = new List<Contact>();
        public frmListContacts()
        {
            InitializeComponent();

            //httpClient.BaseAddress = new Uri("http://localhost:5279/api/Contacts/");
        }



        private async Task _RefreshContactsList()
        {
            await GetAllContacts();
        }


        public async Task GetAllContacts()
        {

            try
            {
                var response = await HttpClientInstance.Client.GetAsync("All");
                //var response = await httpClient.GetAsync("All");
                if (response.IsSuccessStatusCode)
                {
                    var contacts = await response.Content.ReadFromJsonAsync<List<Contact>>();

                    if (contacts != null)
                    {
                        //  dgvContacts.DataSource = contacts;
                        _AllContacts = contacts;
                    }
                    else
                    {
                        MessageBox.Show("No Contacts Found");
                    }
                }

                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("No Contacts Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (comboBox1.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBox1.Text.Trim();

            if (string.IsNullOrEmpty(filterColumn))
            {
                dgvContacts.DataSource = _AllContacts;
                lblRecordsCount.Text = _AllContacts.Count.ToString();
                return;
            }

            // Filter the List<Contact> based on the selected column
            var filteredContacts = _AllContacts.Where(contact =>
            {
                string filterText = txtFilterValue.Text.Trim();

                switch (filterColumn)
                {
                    case "Contact ID":
                        return contact.ContactID.ToString().StartsWith(filterText, StringComparison.OrdinalIgnoreCase);

                    case "FirstName":
                        return contact.FirstName.StartsWith(filterText, StringComparison.OrdinalIgnoreCase);

                    case "LastName":
                        return contact.LastName.StartsWith(filterText, StringComparison.OrdinalIgnoreCase);

                    case "Phone":
                        return contact.Phone.StartsWith(filterText, StringComparison.OrdinalIgnoreCase);

                    case "Email":
                        return contact.Email.StartsWith(filterText, StringComparison.OrdinalIgnoreCase);

                    default:
                        return true;
                }
            }).ToList();

            dgvContacts.DataSource = filteredContacts;
            lblRecordsCount.Text = filteredContacts.Count.ToString();
        }

        private async void frmListContacts_Load(object sender, EventArgs e)
        {

            await GetAllContacts();
            dgvContacts.DataSource = _AllContacts;

            comboBox1.SelectedIndex = 0;
            //lblRecordsCount.Text = dgvClients.Rows.Count.ToString();
            lblRecordsCount.Text = dgvContacts.Rows.Count.ToString();

        }

        private void addNewContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAddEditContact frm = new frmAddEditContact())
            {
                frm.ShowDialog();
            }

            frmListContacts_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAddEditContact frm = new frmAddEditContact((int)dgvContacts.CurrentRow.Cells[0].Value))
            {
                frm.ShowDialog();

            }
            frmListContacts_Load(null, null);

        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int contactId = (int)dgvContacts.CurrentRow.Cells[0].Value;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this contact ?", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                await DeleteContact(contactId);
                frmListContacts_Load(null, null);
            }
        }


        private async Task DeleteContact(int id)
        {
            try
            {

                //var response = await httpClient.DeleteAsync($"{id}");
                var response = await HttpClientInstance.Client.DeleteAsync($"{id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Contact With : " + id + " deleted successfuly.");
                    //Console.WriteLine("Contact with ID : " + id + " deleted successfuly.");
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Invalid Contact id.");
                    //Console.WriteLine("Invalid Contact id.");
                }
                else if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    MessageBox.Show("Error in Server.");
                    //Console.WriteLine("Error in Server.");
                }
                else
                {
                    MessageBox.Show($"Unexpected status code: {response.StatusCode}");
                    // Console.WriteLine($"Unexpected status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                // Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id is selected.
            if (comboBox1.Text == "Contact ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmShowContactInfo frm = new frmShowContactInfo((int)dgvContacts.CurrentRow.Cells[0].Value))
            {
                frm.ShowDialog();

            }
            frmListContacts_Load(null, null);
        }
    }
}
