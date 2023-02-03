using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> avaliableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            avaliableTeamMembers.Add(new PersonModel { FirstName = "Domen", LastName = "Zukovec" });
            avaliableTeamMembers.Add(new PersonModel { FirstName = "Niki", LastName = "Mencin" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Joe", LastName = "Mama" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Deez", LastName = "Nuts" });


        }

        private void WireUpLists()
        {
            selectTeamMemberDropDownComboBox1.DataSource = null;

            selectTeamMemberDropDownComboBox1.DataSource = avaliableTeamMembers;
            selectTeamMemberDropDownComboBox1.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }
             
        private void cellphoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel1_Click(object sender, EventArgs e)
        {

        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValueTextBox1.Text;
                p.LastName = lastNameValueTextBox.Text;
                p.EmailAddress = emailValueTextBox1.Text;
                p.CellphoneNumber = cellphoneValueTextBox.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameValueTextBox1.Text = "";
                lastNameValueTextBox.Text = "";
                emailValueTextBox1.Text = "";
                cellphoneValueTextBox.Text = "";
            } 
            else
            {
                MessageBox.Show("You need to fill in all the fields ;)");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValueTextBox1.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValueTextBox.Text.Length == 0)
            {
                return false;
            }

            if (emailValueTextBox1.Text.Length == 0)
            {
                return false;
            }

            if (cellphoneValueTextBox.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void teamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDownComboBox1.SelectedItem;

            if ( p != null)
            {
                avaliableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }          
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if ( p != null )
            {
                selectedTeamMembers.Remove(p);
                avaliableTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValueTextBox1.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

            // TODO - If we aren't closing this form after creation, reset the form
        }
    }
}
