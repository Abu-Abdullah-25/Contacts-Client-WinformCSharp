using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactApiClient.DTOs;

namespace ContactApiClient
{
    public partial class frmAddEditContact : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _ContactID = -1;
        private Contact _Contact;

        public frmAddEditContact(int ContactID)
        {
            InitializeComponent();

            _ContactID = ContactID;
            _Mode = enMode.Update;
        }

        public frmAddEditContact()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }


        private async Task _FillCountriesInComoboBoxAsync()
        {
            //DataTable dtCountries = clsCountry.GetAllCountries();

            //foreach (DataRow row in dtCountries.Rows)
            //{

            //    cbCountry.Items.Add(row["CountryName"]);

            //}

            //here we will call the "getlAllContacts" method of json-web api
            await GetAllCountries();

            //await task1;
            //cbCountry.SelectedIndex = 0;
        }


        private async Task _LoadData()
        {
            //I have question here
            Task task1 = _FillCountriesInComoboBoxAsync();

            await task1;
            cbCountries.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Contact";
                _Contact = new Contact();
                return;
            }

            _Contact = await GetContactById(_ContactID);

            //_Contact = clsContact.Find(_ContactID);

            if (_Contact == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _ContactID);
                this.Close();

                return;
            }


            //All these about 'AddNewContact'

            lblTitle.Text = "Edit Contact ID = " + _ContactID;
            lblContactID.Text = _ContactID.ToString();
            txtFirstName.Text = _Contact.FirstName;
            txtLastName.Text = _Contact.LastName;
            txtEmail.Text = _Contact.Email;
            txtPhone.Text = _Contact.Phone;
            txtAddress.Text = _Contact.Address;
            dtpDateOfBirth.Value = _Contact.DateOfBirth;

            if (_Contact.ImagePath != "" && _Contact.ImagePath != null)
            {
                pbPersonImage.Load(_Contact.ImagePath);
            }

            llRemoveImage.Visible = (_Contact.ImagePath != "" && _Contact.ImagePath != null);

            //this will select the country in the combobox.
            Country c1 = await GetCountryById(_Contact.CountryID);
            cbCountries.SelectedIndex = cbCountries.FindString(c1.CountryName);
            //cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(_Contact.CountryID).CountryName);

        }

        private async Task<Contact> GetContactById(int id)
        {
            Contact contact1 = new Contact();
            try
            {

                var response = await HttpClientInstance.Client.GetAsync($"{id}");
                if (response.IsSuccessStatusCode)
                {
                    var contact = await response.Content.ReadFromJsonAsync<Contact>();
                    if (contact != null)
                    {
                        contact1.ContactID = contact.ContactID;
                        contact1.FirstName = contact.FirstName;
                        contact1.LastName = contact.LastName;
                        contact1.Email = contact.Email;
                        contact1.Phone = contact.Phone;
                        contact1.Address = contact.Address;
                        contact1.DateOfBirth = contact.DateOfBirth;
                        contact1.CountryID = contact.CountryID;
                        contact1.ImagePath = contact.ImagePath;
                        //Console.WriteLine($"Contact ID: {contact.ContactID}");
                        //Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
                        //Console.WriteLine($"Email: {contact.Email}");
                        //Console.WriteLine($"Phone: {contact.Phone}");
                        //Console.WriteLine($"Address: {contact.Address}");
                        //Console.WriteLine($"Date of Birth: {contact.DateOfBirth}");
                        //Console.WriteLine($"Country ID: {contact.CountryID}");
                        //Console.WriteLine($"Image Path: {contact.ImagePath ?? "N/A"}"); // Using null-coalescing operator
                        //Console.WriteLine();
                    }

                    else
                    {
                        return null;
                        //Console.WriteLine("contact not found");
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine("Invalid Contact ID");
                }

                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine("No Contact Found");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return contact1;
        }

        private async Task<Country> GetCountryByName(string name)
        {

            try
            {


                var response = await HttpCountriesClientInstance.Client.GetAsync($"countryName/{name}");
                if (response.IsSuccessStatusCode)
                {
                    var country = await response.Content.ReadFromJsonAsync<Country>();
                    if (country != null)
                    {
                        return country;
                    }

                    else
                    {
                        return null;
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine("Invalid Contact ID");
                }

                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine("No Contact Found");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }


        private async Task<Country> GetCountryById(int Id)
        {

            try
            {


                var response = await HttpCountriesClientInstance.Client.GetAsync($"{Id}");
                if (response.IsSuccessStatusCode)
                {
                    var country = await response.Content.ReadFromJsonAsync<Country>();
                    if (country != null)
                    {
                        return country;
                    }

                    else
                    {
                        return null;
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine("Invalid Contact ID");
                }

                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine("No Contact Found");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }


        public async Task GetAllCountries()
        {
            //List<Country> countriesList = null;
            try
            {
                var response = await HttpCountriesClientInstance.Client.GetAsync("All");
                if (response.IsSuccessStatusCode)
                {
                    var countriesList = await response.Content.ReadFromJsonAsync<List<Country>>();
                    if (countriesList != null)
                    {
                        //dgvContacts.DataSource = contacts;
                        //Here i want to show the CountryName into combox named 'cbCountries'

                        foreach (var country in countriesList)
                        {
                            cbCountries.Items.Add(country.CountryName);
                        }

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

        private async Task AddContact(Contact newContact)
        {
            try
            {

                var response = await HttpClientInstance.Client.PostAsJsonAsync("", newContact);

                if (response.IsSuccessStatusCode)
                {
                    var contact = await response.Content.ReadFromJsonAsync<Contact>();

                    if (contact != null)
                    {
                        _Contact = contact;

                        MessageBox.Show("Success");

                    }
                    else
                    {
                        MessageBox.Show("Failed");
                        //Console.WriteLine("Contact not found after addition.");
                    }
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Invalid data")
;                   // Console.WriteLine("Invalid Contact data.");
                }
                else if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    MessageBox.Show("Error in server");
                    //  Console.WriteLine("Error in Server.");
                }
                else
                {
                    MessageBox.Show("unexpected dta");
                    //Console.WriteLine($"Unexpected status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private async Task UpdateContact(int id, Contact newContact)
        {
            try
            {

                var response = await HttpClientInstance.Client.PutAsJsonAsync($"{id}", newContact);

                if (response.IsSuccessStatusCode)
                {
                    var contact = await response.Content.ReadFromJsonAsync<Contact>();

                    if (contact != null)
                    {
                        _Contact.ContactID = contact.ContactID;
                        _Contact.FirstName = contact.FirstName;
                        _Contact.LastName = contact.LastName;
                        _Contact.Email = contact.Email;
                        _Contact.Phone = contact.Phone;
                        _Contact.Address = contact.Address;
                        _Contact.DateOfBirth = contact.DateOfBirth;
                        _Contact.CountryID = contact.CountryID;
                        _Contact.ImagePath = contact.ImagePath;

                        MessageBox.Show("Success");

                    }
                    else
                    {
                        // Console.WriteLine("Contact not found after addition.");
                    }
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Invalid contact data");
                    // Console.WriteLine("Invalid Contact data.");
                }
                else if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    MessageBox.Show("Error in Server.");
                    // Console.WriteLine("Error in Server.");
                }
                else
                {
                    MessageBox.Show($"Unexpected status code: {response.StatusCode}");
                    //Console.WriteLine($"Unexpected status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");

                // Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            //int CountryID = clsCountry.Find(cbCountry.Text).ID;
            Country c1 = await GetCountryByName(cbCountries.Text);
            _Contact.CountryID = c1.CountryID;

            _Contact.FirstName = txtFirstName.Text;
            _Contact.LastName = txtLastName.Text;
            _Contact.Email = txtEmail.Text;
            _Contact.Phone = txtPhone.Text;
            _Contact.Address = txtAddress.Text;
            _Contact.DateOfBirth = dtpDateOfBirth.Value;
            //_Contact.CountryID = 3;
            //_Contact.ImagePath = "string";

            if (pbPersonImage.ImageLocation != null)
                _Contact.ImagePath = pbPersonImage.ImageLocation;
            else
                _Contact.ImagePath = "";

            if (_Mode == enMode.AddNew)
            {
                await AddContact(_Contact);
            }
            else
            {
                await UpdateContact(_ContactID, _Contact);
            }

            _Mode = enMode.Update;

            lblTitle.Text = "Edit Contact ID = " + _Contact.ContactID;
            lblContactID.Text = _Contact.ContactID.ToString();
        }


        private void llOpenFileDialog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pbPersonImage.Load(selectedFilePath);
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pbPersonImage.ImageLocation = null;
            llRemoveImage.Visible = false;

        }

        private async void frmAddEditContact_Load(object sender, EventArgs e)
        {
            Task t = _LoadData();
            await t;
        }
    }
}
