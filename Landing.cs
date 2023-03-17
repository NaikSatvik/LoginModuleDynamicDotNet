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
        // public static string ConnectionString = @"Data Source = DESKTOP-4VH316L\SQLEXPRESS; Initial Catalog=Bank; Integrated Security=True";
        public static string ConnectionString = @"Data Source = SATVIKNAIK\SQLEXPRESS; Initial Catalog=Bank; Integrated Security=True";
        SqlConnection cnn = new SqlConnection(ConnectionString);
        #endregion

        // global variables
        DateTime now = DateTime.Now;
        app app = new app();
        public int userId = 0;

        public landingForm()
        {
            InitializeComponent();
            withdrawPanel.Hide();
            depositPanel.Hide();
            withdrawPin.PasswordChar = '*';
            depositPin.PasswordChar = '*';
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
                        this.welcomeMsg.Text = "Welcome " + dr.GetString(4) + " " + dr.GetString(5);
                        this.accDetAccNum.Text = dr.GetString(1);
                        this.balance.Text = dr.GetString(2);
                        this.viewEmail.Text = dr.GetString(6);
                        this.viewMobile.Text = dr.GetString(7);
                        this.viewFname.Text = dr.GetString(4);
                        this.viewLname.Text = dr.GetString(5);
                        this.viewGender.Text = dr.GetString(8);
                        this.viewAddress.Text = dr.GetString(9);
                    }
                    dr.Close();
                }
                else
                    this.welcomeMsg.Text = "Try login again.";

                // initializing data table
                DataTable dt = new DataTable();
                // add columns
                dt.Columns.Add("Timestamp", typeof(DateTime));
                dt.Columns.Add("Credit", typeof(string));
                dt.Columns.Add("Debit", typeof(string));
                dt.Columns.Add("Balance", typeof(string));

                string fetchTransactions = "SELECT * FROM transactionHistory WHERE userId = @userId ORDER BY timestamp DESC";
                SqlCommand command1 = new SqlCommand(fetchTransactions, cnn);
                command1.Parameters.AddWithValue("@userId", userId);
                SqlDataReader dr1 = command1.ExecuteReader();
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        dt.Rows.Add(dr1.GetDateTime(7), dr1.GetString(4), dr1.GetString(3), dr1.GetString(6));
                    }
                    this.viewTransactionGrid.DataSource = dt;
                } else
                {
                    this.viewTransactionGrid.Hide();
                    this.ackTransactions.Text = "No transactions have been performed";
                }
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

        private void withdrawRed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            withdrawPanel.Show();
            depositPanel.Hide();
        }

        private void depositRed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            depositPanel.Show();
            withdrawPanel.Hide();
        }

        // withdraw functionality
        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.withdrawAmt.Text) == true || String.IsNullOrEmpty(this.withdrawPin.Text) == true)
                this.ackAtm.Text = "Please enter amount and PIN";
            else if (int.Parse(this.withdrawAmt.Text) > int.Parse(this.balance.Text))
                this.ackAtm.Text = "Not enough balance";
            else
            {
                string chkuser = "select COUNT(*) from userMaster where userId = @userId and pin = CONVERT(binary(50),@pin)";
                try
                {
                    cnn.Open();
                    SqlCommand command = new SqlCommand(chkuser, cnn);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@pin", app.ComputeSha256Hash(this.withdrawPin.Text));
                    Int32 count = (Int32)command.ExecuteScalar();
                    if (count == 1)
                    {
                        string updateBalance = "UPDATE userMaster SET accBalance = @accBalance WHERE userId = @userId";
                        SqlCommand command1 = new SqlCommand(updateBalance, cnn);
                        command1.Parameters.AddWithValue("@accBalance", (int.Parse(this.balance.Text) - int.Parse(this.withdrawAmt.Text)));
                        command1.Parameters.AddWithValue("@userId", userId);

                        int result = command1.ExecuteNonQuery();
                        if (result < 0)
                            this.ackAtm.Text = "ATM is facing some issue. Try later.";
                        else
                        {
                            this.ackAtm.Text = "";
                            MessageBox.Show("Amount Debited Successfully");

                            string transactionInsert = "INSERT INTO transactionHistory (userId, accNum, debited, credited, transactionType, currBal, timestamp) " +
                                                        "VALUES (@userId, @accNum, @debited, @credited, @transactionType, @currBal, @timestamp)";
                            try
                            {
                                SqlCommand command2 = new SqlCommand(transactionInsert, cnn);
                                command2.Parameters.AddWithValue("@userId", this.userId);
                                command2.Parameters.AddWithValue("@accNum", this.accDetAccNum.Text);
                                command2.Parameters.AddWithValue("@debited", this.withdrawAmt.Text);
                                command2.Parameters.AddWithValue("@credited", '-');
                                command2.Parameters.AddWithValue("@transactionType", "Withdrawal");
                                command2.Parameters.AddWithValue("@currBal", (int.Parse(this.balance.Text) - int.Parse(this.withdrawAmt.Text)));
                                command2.Parameters.AddWithValue("@timestamp", now.ToLocalTime());
                                int result1 = command2.ExecuteNonQuery();

                                if (result1 > 0)
                                {
                                    withdrawAmt.Clear();
                                    withdrawPin.Clear();
                                    cnn.Close();
                                    landingForm_Load(sender, e);
                                }
                            }
                            catch (SqlException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                cnn.Close();
                            }
                        }
                    } else
                        this.ackAtm.Text = "Incorrect PIN";
                }
                catch (SqlException ex)
                {
                    this.welcomeMsg.Text = "ATM is facing some issue. Try later.";
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        // deposit functionality
        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.depositAmt.Text) == true || String.IsNullOrEmpty(this.depositPin.Text) == true)
                this.ackAtm.Text = "Please enter amount and PIN";
            else
            {
                string chkuser = "select COUNT(*) from userMaster where userId = @userId and pin = CONVERT(binary(50),@pin)";
                try
                {
                    cnn.Open();
                    SqlCommand command = new SqlCommand(chkuser, cnn);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@pin", app.ComputeSha256Hash(this.depositPin.Text));
                    Int32 count = (Int32)command.ExecuteScalar();
                    if (count == 1)
                    {
                        string updateBalance = "UPDATE userMaster SET accBalance = @accBalance WHERE userId = @userId";
                        SqlCommand command1 = new SqlCommand(updateBalance, cnn);
                        command1.Parameters.AddWithValue("@accBalance", (int.Parse(this.balance.Text) + int.Parse(this.depositAmt.Text)));
                        command1.Parameters.AddWithValue("@userId", userId);

                        int result = command1.ExecuteNonQuery();
                        if (result < 0)
                            this.ackAtm.Text = "ATM is facing some issue. Try later.";
                        else
                        {
                            this.ackAtm.Text = "";
                            MessageBox.Show("Amount Credited Successfully");

                            string transactionInsert = "INSERT INTO transactionHistory (userId, accNum, debited, credited, transactionType, currBal, timestamp) " +
                                                        "VALUES (@userId, @accNum, @debited, @credited, @transactionType, @currBal, @timestamp)";
                            try
                            {
                                SqlCommand command2 = new SqlCommand(transactionInsert, cnn);
                                command2.Parameters.AddWithValue("@userId", this.userId);
                                command2.Parameters.AddWithValue("@accNum", this.accDetAccNum.Text);
                                command2.Parameters.AddWithValue("@debited", '-');
                                command2.Parameters.AddWithValue("@credited", this.depositAmt.Text);
                                command2.Parameters.AddWithValue("@transactionType", "Deposit");
                                command2.Parameters.AddWithValue("@currBal", (int.Parse(this.balance.Text) + int.Parse(this.depositAmt.Text)));
                                command2.Parameters.AddWithValue("@timestamp", now.ToLocalTime());
                                int result1 = command2.ExecuteNonQuery();

                                if (result1 > 0)
                                {
                                    depositAmt.Clear();
                                    depositPin.Clear();
                                    cnn.Close();
                                    landingForm_Load(sender, e);
                                }
                            }
                            catch (SqlException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                cnn.Close();
                            }
                        }
                    }
                    else
                        this.ackAtm.Text = "Incorrect PIN";
                }
                catch (SqlException ex)
                {
                    this.welcomeMsg.Text = "ATM is facing some issue. Try later.";
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }
    }
}
