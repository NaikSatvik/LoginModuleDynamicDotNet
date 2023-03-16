using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BankDynamic;

namespace LoginRegister
{
    public partial class app : Form
    {
        #region SQL
        public static string ConnectionString = @"Data Source = DESKTOP-4VH316L\SQLEXPRESS; Initial Catalog=Bank; Integrated Security=True";

        // public static string ConnectionString = @"Data Source = SATVIKNAIK\SQLEXPRESS; Initial Catalog=Bank; Integrated Security=True";

        SqlConnection cnn = new SqlConnection(ConnectionString);
        #endregion

        public app()
        {
            InitializeComponent();
            lgnPassword.PasswordChar = '*';
            password.PasswordChar = '*';
            confPassword.PasswordChar = '*';
        }

        // compute hash code SHA-256
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        #region User Validations
        // validate all user inputs
        public bool isEmpty()
        {
            if (String.IsNullOrEmpty(this.accNum.Text) == true || 
                String.IsNullOrEmpty(this.email.Text) == true ||
                String.IsNullOrEmpty(this.fname.Text) == true ||
                String.IsNullOrEmpty(this.lname.Text) == true ||
                String.IsNullOrEmpty(this.address.Text) == true ||
                String.IsNullOrEmpty(this.password.Text) == true ||
                String.IsNullOrEmpty(this.confPassword.Text) == true || 
                this.male.Checked == false && 
                this.female.Checked == false && 
                this.other.Checked == false
                )
            {
                return true;
            } else
            {
                return false;
            }
        }

        // check email id
        public bool IsValidEmail(string email)
        {
            var valid = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }

        // check whether user already exists or not
        public bool userExist()
        {
            bool status = false;
            string chkAccNum = "select * from userMaster where accNumber = @accNumber or email = @email";
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand(chkAccNum, cnn);
                command.Parameters.AddWithValue("@accNumber", this.accNum.Text);
                command.Parameters.AddWithValue("@email", this.email.Text);

                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    status = true;
                } else
                {
                    status = false;
                }
            }
            catch (SqlException ex)
            {
                this.ackRegisterMsg.Text = "Error inserting data into Database!";
                Console.WriteLine(ex.Message);
            } finally
            {
                cnn.Close();
            }
            return status;
        }

        // clear all registration form inputs
        public void clearInputs()
        {
            this.accNum.Clear();
            this.email.Clear();
            this.mobile.Clear();
            this.fname.Clear();
            this.lname.Clear();
            this.address.Clear();
            this.password.Clear();
            this.confPassword.Clear();
            this.male.Checked = false;
            this.female.Checked = false;
            this.other.Checked = false;
        }
        #endregion
        
        // registration btn click event
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty() == true)
            {
                this.ackRegisterMsg.Text = "Fill all the details.";
            }
            else if (userExist() == true)
            {
                this.ackRegisterMsg.Text = "User already exists. Try Login.";
            }
            else
            {
                // checking gender
                string gender;
                if (this.male.Checked)
                {
                    gender = this.male.Text;
                }
                else if (this.female.Checked)
                {
                    gender = this.female.Text;
                }
                else if (this.other.Checked)
                {
                    gender = this.other.Text;
                }
                else
                {
                    gender = "-";
                }

                // validating email & password and registering the user
                string password;
                if (IsValidEmail(this.email.Text) == false)
                {
                    this.ackRegisterMsg.Text = "Email format didn't matched";
                }
                else if (String.Compare(this.password.Text, this.confPassword.Text) == 0)
                {
                    DateTime now = DateTime.Now;
                    // Console.WriteLine(now.ToLocalTime());
                    password = this.password.Text;
                    String insertUser = "INSERT INTO userMaster (accNumber, accBalance, pin, fname, lname, email, mobile, gender, address, createdAt, lastModified)" +
                        "VALUES (@accNumber,@accBalance,CONVERT(binary(50), @pin),@fname,@lname,@email,@mobile,@gender,@address,@createdAt,@lastModified)";
                    
                    try
                    {
                        cnn.Open();
                        SqlCommand command = new SqlCommand(insertUser, cnn);
                        command.Parameters.AddWithValue("@accNumber", this.accNum.Text);
                        command.Parameters.AddWithValue("@accBalance", "0");
                        command.Parameters.AddWithValue("@pin", ComputeSha256Hash(password));
                        command.Parameters.AddWithValue("@fname", this.fname.Text);
                        command.Parameters.AddWithValue("@lname", this.lname.Text);
                        command.Parameters.AddWithValue("@email", this.email.Text);
                        command.Parameters.AddWithValue("@mobile", this.label.Text);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@address", this.address.Text);
                        command.Parameters.AddWithValue("@createdAt", now.ToLocalTime());
                        command.Parameters.AddWithValue("@lastModified", now.ToLocalTime());

                        int result = command.ExecuteNonQuery();
                        if (result < 0)
                            this.ackRegisterMsg.Text = "Error inserting data into Database!";
                        else
                        {
                            clearInputs();
                            this.ackRegisterMsg.Text = "User registered successfully!!";
                        }
                    } catch (SqlException ex)
                    {
                        this.ackRegisterMsg.Text = "Error inserting data into Database!";
                        Console.WriteLine(ex.Message);
                    } finally
                    {
                        cnn.Close();
                    }
                }
                else
                {
                    this.ackRegisterMsg.Text = "Password didn't matched. Try Again.";
                }
            }
        }

        // switch to register tab
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tab.SelectedIndex = 1;
        }

        // login btn click event
        private void lgnBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.lgnAccNum.Text) == true || String.IsNullOrEmpty(this.lgnPassword.Text) == true)
            {
                this.lgnAckBox.Text = "Please enter username & password.";
            }
            else
            {
                string chkAccNum = "select userId from userMaster where accNumber = @accNumber and pin = CONVERT(binary(50),@pin)";
                try
                {
                    cnn.Open();
                    SqlCommand command = new SqlCommand(chkAccNum, cnn);
                    command.Parameters.AddWithValue("@accNumber", this.lgnAccNum.Text);
                    command.Parameters.AddWithValue("@pin", ComputeSha256Hash(this.lgnPassword.Text));
                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lgnAccNum.Clear();
                            lgnPassword.Clear();
                            this.lgnAckBox.Text = "";
                            int userId = dr.GetInt32(0);
                            // Console.WriteLine(userId);
                            landingForm lForm = new landingForm();
                            lForm.userId = userId;
                            lForm.ShowDialog();
                        }
                    }
                    else
                        this.lgnAckBox.Text = "Sorry user dosen't exists.";
                }
                catch (SqlException ex)
                {
                    this.ackRegisterMsg.Text = "Error fetching data from Database!";
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
