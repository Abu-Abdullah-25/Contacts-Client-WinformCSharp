namespace ContactApiClient
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            _CustomizeDesign();
            _ShowHamePage();
        }



        private void _CustomizeDesign()
        {
            panelManageContactsSubMenu.Visible = false;

        }

        private void HideSubMenu()
        {
            if (panelManageContactsSubMenu.Visible == true)
                panelManageContactsSubMenu.Visible = false;

        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }

            else
                SubMenu.Visible = false;
        }



        private Form activeForm = null;
        private void OpenForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        void _ShowHamePage()
        {
            OpenForm(new fmHome());
            //Your Code Here

            HideSubMenu();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManageContactsMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelManageContactsSubMenu);
        }

        private void btnListContact_Click(object sender, EventArgs e)
        {
            OpenForm(new frmListContacts());
            //Your Code Here

            HideSubMenu();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            _ShowHamePage();
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            OpenForm(new frmAddEditContact());
            //Your Code Here

            HideSubMenu();
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            //Your Code Here
            //OpenForm(new frmDeleteContact());
            HideSubMenu();
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            //Your Code Here
            //OpenForm(new frmDeleteContact());
            HideSubMenu();
        }

    }
}
