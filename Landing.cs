using LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDynamic
{
    public partial class landingForm : Form
    {
        #region SQL
        public static string ConnectionString = @"Data Source = DESKTOP-4VH316L\SQLEXPRESS; Initial Catalog=Bank; Integrated Security=True";
        // public static string ConnectionString = @"Data Source = SATVIKNAIK\SQLEXPRESS; Initial Catalog=Bank; Integrated Security=True";
        SqlConnection cnn = new SqlConnection(ConnectionString);
        #endregion

        // global variables
        public int userId = 0;

        public landingForm()
        {
            InitializeComponent();
        }

        private void landingForm_Load(object sender, EventArgs e)
        {
            landingTab.SelectedIndex = 1;
            string getUserDetails = "select * from userMaster where userId = @userId";
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand(getUserDetails, cnn);
                command.Parameters.AddWithValue("@userId", userId);
                SqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        this.welcomeMsg.Text = "Welcome "+dr.GetString(4)+" "+ dr.GetString(5);
                        this.accDetAccNum.Text = dr.GetString(1);
                        this.balance.Text = dr.GetString(2);
                        this.viewEmail.Text = dr.GetString(6);
                        this.viewMobile.Text = dr.GetString(7);
                        this.viewFname.Text = dr.GetString(4);
                        this.viewLname.Text = dr.GetString(5);
                        this.viewGender.Text = dr.GetString(8);
                        this.viewAddress.Text = dr.GetString(9);
                    }
                }
                else
                    this.welcomeMsg.Text = "Try login again.";
            }
            catch (SqlException ex)
            {
                this.welcomeMsg.Text = "Sorry something went wrong. Try login again.";
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        // edit profile functionality
        private void editProfileBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.viewFname.Text) == true || String.IsNullOrEmpty(this.viewLname.Text) == true || String.IsNullOrEmpty(this.viewAddress.Text) == true)
                this.ackViewProfile.Text = "Kindly fill all the details.";
            else
            {
                string updateUserDetails = "UPDATE userMaster SET fname = @fname, lname = @lname, address = @address, lastModified = @lastModified where userId = @userId";
                try
                {
                    DateTime now = DateTime.Now;
                    cnn.Open();
                    SqlCommand command = new SqlCommand(updateUserDetails, cnn);
                    command.Parameters.AddWithValue("@fname", this.viewFname.Text);
                    command.Parameters.AddWithValue("@lname", this.viewLname.Text);
                    command.Parameters.AddWithValue("@address", this.viewAddress.Text);
                    command.Parameters.AddWithValue("@lastModified", now.ToLocalTime());
                    command.Parameters.AddWithValue("@userId", userId);

                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                        this.ackViewProfile.Text = "Error updating data into Database!";
                    else
                        MessageBox.Show("Your details have been updated successfully!!");
                }
                catch (SqlException ex)
                {
                    this.ackViewProfile.Text = "Sorry something went wrong. Try login again.";
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        // logout
        private void logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            landingForm.ActiveForm.Close();
        }
    }
}
