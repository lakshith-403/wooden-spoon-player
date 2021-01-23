using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp;
using Newtonsoft.Json;


namespace VideoPlayer
{
    public partial class login : MetroForm
    {
        public login()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UZQZJZ773fUSRcfDxUgjbJrLG4Zt0DxmK7cpP7iC",
            BasePath = "https://player-6969-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        string pass = "-1";

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string room = txt_room.Text;
            data.username = username;
            data.room = room;

            if (room == "" || username == "" || password == "")
            {
                lbl_result_login.Text = "Incomplete data";
                return;
            }

            try
            {
                client = new FirebaseClient(ifc);
                Console.WriteLine("users/" + username);
                FirebaseResponse res = client.Get("users/" + username + "/");
                pass = JsonConvert.DeserializeObject<string>(res.Body.ToString());
            }catch(Exception E)
            {
                lbl_result_login.Text = "Username is incorrect";
                return;
            }

            if (pass == null)
            {
                lbl_result_login.Text = "Username is incorrect";
                return;
            }
            if (pass != password)
            {
                lbl_result_login.Text = "Password is incorrect";
                Console.WriteLine(pass + "<>");
            }
            else
            {
                VideoPlayer.panel_player main = new panel_player();
                this.Hide();
                main.Show();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(lbl_password_signup.Text != lbl_confirmpassword_signup.Text)
            {
                lbl_result_signup.Text = "Password confirmation does not match";
                return;
            }


            string username = lbl_username_singup.Text;
            string password = lbl_password_signup.Text;
            string pass = "*";

            if (username == "" ||  password == "")
            {
                lbl_result_login.Text = "Incomplete data";
                return;
            }

            try
            {
                client = new FirebaseClient(ifc);
                Console.WriteLine("users/" + username);
                FirebaseResponse res = client.Get("/users/" + username + "/");
                pass = JsonConvert.DeserializeObject<string>(res.Body.ToString());
            }
            catch (Exception E)
            {
                lbl_result_signup.Text = "Username is incorrect";
                Console.WriteLine(E.Message);
                return;
            }
            if (pass != null)
            {
                lbl_result_signup.Text = "Username is taken";
                return;
            }


            try
            {
                client = new FirebaseClient(ifc);
                Console.WriteLine("users/" + username);
                client.Set<string>("users/" + username, password);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }

            lbl_result_signup.ForeColor = Color.Blue;
            lbl_result_signup.Text = "succesfull! Login to continue";

        }

        private void tab_sign_Click(object sender, EventArgs e)
        {

        }
    }
}
