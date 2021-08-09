using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace userLogin
{
    public partial class Form1 : Form
    {
       /* MySqlCommand cmd;
        MySqlConnection con;
        MySqlDataReader red;
        MySqlDataAdapter da;)*/
        
        public static ArrayList user;
        public static ArrayList password;

       // string[,] UserNamePassword = { { "Waiter", "waiter", "123456" }, { "Cheif","cheif", "78963" }, { "Cashier","cashier","32147" } };
       
        public Form1()
        {
            InitializeComponent();
            MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=restaurent");
            MySqlCommand cmd = new MySqlCommand("select * from userlogin", con);
            con.Open();
            MySqlDataReader red = cmd.ExecuteReader();
            user = new ArrayList();
            password = new ArrayList();

            while (red.Read())
            {
                user.Add(red.GetString("username"));
                password.Add(red.GetString("password"));
                Console.WriteLine("00045");
            }
            con.Close();
            Console.WriteLine("closed");
        }
        
        private void dbconnect()
        {
            
        }
        private void usertypecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void logIn_Click(object sender, EventArgs e)
        {

            String name = usernametb.Text;
            String pass = passwordtb.Text;
            
            int poss = -1;
            for (int i = 0; i < user.Count; i++)
            {
                if (name == Convert.ToString(user[i]))
                {
                    poss = i;
                    break;
                }

                Console.WriteLine(Convert.ToString(user[i]) + "==>" + Convert.ToString(password[i]));
            }

            if (poss == -1)
            {
                usernametb.Text="Username Error";
                Console.WriteLine("erro 001");
            }
            else if (Convert.ToString(password[poss]) == pass)
            {
                Console.WriteLine("Open any form");
                
                frmwaiter waiter = new frmwaiter();
               waiter.ShowDialog();
                
           }
            
            else
            {
                usernametb.Text = "Password Error";
            }
           
        }
    }

}
