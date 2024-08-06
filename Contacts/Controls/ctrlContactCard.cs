using ContactApiClient.DTOs;
using ContactApiClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApiClient
{
    public partial class ctrlContactCard : UserControl
    {
        private Contact _Contact;

        private int _ContactID = -1;

        public int ContactID
        {
            get { return _ContactID; }
        }

        public Contact SelectedContactInfo
        {
            get { return _Contact; }
        }


        public ctrlContactCard()
        {
            InitializeComponent();
        }

        public async void LoadContactInfo(int ContactID)
        {
            //_Contact = Contact.Find(ContactID);
            _Contact =await  GetContactById(ContactID);

            if (_Contact == null)
            {
                ResetContactInfo();
                MessageBox.Show("No Contact with ContactID = " + ContactID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           _FillContactInfo();
        }

        static async Task<Contact> GetContactById(int id)
        {
            try
            {
                //Console.WriteLine("\n_____________________________");
                //Console.WriteLine("\nFetching contact Info...\n");


                var response = await HttpClientInstance.Client.GetAsync($"{id}");
                if (response.IsSuccessStatusCode)
                {
                    var contact = await response.Content.ReadFromJsonAsync<Contact>();
                    if (contact != null)
                    {
                        return contact;
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
                        Console.WriteLine("contact not found");
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

        public void ResetContactInfo()
        {
            _ContactID = -1;
            lblContactID.Text = "[????]";
            //lbNationalNo.Text = "[????]";
          //  lbContactFullName.Text = "[????]";
            lblName.Text = "[????]";
            //lbGendor.Image = Resources.Man_32;
           // lbGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            //pbContactImage.Image = Properties.Resources.Add_Contact_72;

        }

        private async void _FillContactInfo()
        {

            llEditContactInfo.Enabled = true;
            _ContactID = _Contact.ContactID;
            lblContactID.Text = _Contact.ContactID.ToString();
            lblName.Text = _Contact.FirstName + " " + _Contact.LastName;
            lblEmail.Text = _Contact.Email;
            lblPhone.Text = _Contact.Phone;
            lblDateOfBirth.Text = _Contact.DateOfBirth.ToShortDateString();

            //this will select the country in the combobox.
            Country c1 = await GetCountryById(_Contact.CountryID);
            lblCountry.Text = c1.CountryName;
            lblAddress.Text = _Contact.Address;

            _LoadContactImage();

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

        private void llEditContactInfo_LinkClicked(object sender , EventArgs e)
        {
            frmAddEditContact frm = new frmAddEditContact(_ContactID);
            frm.ShowDialog();

            //refresh
            LoadContactInfo(_ContactID);
        }


        private void _LoadContactImage()
        {

            string ImagePath = _Contact.ImagePath;
            if (ImagePath != "" && ImagePath != null)
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
