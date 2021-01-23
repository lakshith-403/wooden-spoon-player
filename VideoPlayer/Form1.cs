﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using MetroFramework.Forms;


namespace VideoPlayer
{
    public partial class panel_player : MetroForm
    {
        public panel_player()
        {
            InitializeComponent();
        }
        bool maximized = false;
        string username = "Lakshith";
        string room = "default";

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UZQZJZ773fUSRcfDxUgjbJrLG4Zt0DxmK7cpP7iC",
            BasePath = "https://player-6969-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Name";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            panel_main.Dock = DockStyle.Fill;
            username = VideoPlayer.data.username;
            room = VideoPlayer.data.room;
            try
            {
                client = new FirebaseClient(ifc);
                client.Set<string>(room+"/chat/" + username, "init");
                client.Set<string>(room + "/media/player/isPlaying/" , "no");
                chatData.Add(username, "init");
                updateData();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        Dictionary<string, string> data;
        async void updateData()
        {
            while (true)
            {
                //await Task.Delay(500);
                FirebaseResponse res = await client.GetAsync(room+"/media/player/");
                data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());
                if (data.ElementAt(0).Value == "yes")
                {
                    try
                    {
                        input.Ctlcontrols.play();
                    }
                    catch
                    {

                    }
                }
                else
                {
                    try
                    {
                        input.Ctlcontrols.pause();
                    }
                    catch
                    {

                    }
                }


                //chat 
                res = await client.GetAsync(room+"/chat/");
                data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());
                for (int x = 0; x < data.Count; x++)
                {
                    if (data.ElementAt(x).Value == "init") continue;
                    updateChat(data.ElementAt(x).Key, data.ElementAt(x).Value);
                }
            }
        }

        Dictionary<string, string> chatData = new Dictionary<string, string>();

        void updateChat(string user,string text)
        {
            try
            {
                if (chatData[user] != text)
                {
                    chatData[user] = text;
                    //chat.Text += user + " : " + text + "\n";
                    addText(user,text);
                }
            }
            catch (KeyNotFoundException)
            {
                chatData.Add(user, text);
                //chat.Text += user + " : " + text + "\n";
                addText(user,text);
            }
        }

        private void addText(string user,string text)
        {
            Label lbl_text = new Label();
            Label lbl_user = new Label();
            lbl_text.Text = text;
            lbl_user.Text = user;
            lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_text.Font = new System.Drawing.Font("Microsoft YaHei Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            if (user == username) lbl_user.ForeColor = Color.Blue;
            else lbl_user.ForeColor = Color.Red;
            lbl_user.AutoSize = true;
            lbl_text.AutoSize = true;
            chatPanel.Controls.Add(lbl_user);
            chatPanel.Controls.Add(lbl_text);
        }

        private void axWindowsMediaPlayer1_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {
            Console.WriteLine(e.nKeyAscii);
            if (e.nKeyAscii == 27)
            {
                TableLayoutColumnStyleCollection styles = this.panel_main.ColumnStyles;
                int i = 0;
                foreach (ColumnStyle style in styles)
                {
                    int perc;
                    if (i++ % 2 == 0) perc = 80;
                    else perc = 20;
                    style.SizeType = SizeType.Percent;
                    if (style.Width == 80) perc = 100;
                    else if (style.Width == 20) perc = 0;
                    style.Width = perc;
                    Console.WriteLine(style.Width);
                }
            }else if(e.nKeyAscii == 109)
            {
                if (maximized == false)
                {
                    this.WindowState = FormWindowState.Maximized;
                    maximized = true;
                    if (input.playState == WMPLib.WMPPlayState.wmppsPlaying)

                    {

                        input.stretchToFit = true;

                        input.Width *= 1;

                        input.Height *= 1;

                        input.fullScreen = true;

                    }
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    maximized = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void player_Enter(object sender, EventArgs e)
        {

        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            
        }

        private void txtin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                client = new FirebaseClient(ifc);
                client.Set<string>(room+"/chat/" + username, txtin.Text);
                txtin.Text = "";
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            TableLayoutColumnStyleCollection styles = this.panel_main.ColumnStyles;
            int i = 0;
            foreach (ColumnStyle style in styles)
            {
                int perc;
                if (i++ % 2 == 0) perc = 80;
                else perc = 20;
                style.SizeType = SizeType.Percent;
                if (style.Width == 80) perc = 100;
                else if (style.Width == 20) perc = 0;
                style.Width = perc;
                Console.WriteLine(style.Width);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Videos | *.mp4;*.wav;*.avi | all files | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                input.settings.autoStart = true;
                input.URL = ofd.FileName;
                input.Ctlcontrols.play();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                client.Set<string>(room + "/media/player/isPlaying", "yes");
            }
            catch { }
            input.Ctlcontrols.play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                client.Set<string>(room + "/media/player/isPlaying", "no");
            }
            catch { }
            input.Ctlcontrols.pause();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //chat.Text += txtin.Text + "\n";
            client = new FirebaseClient(ifc);
            client.Set<string>(room + "/chat/" + username, txtin.Text);
            txtin.Text = "";
        }
    }
}
