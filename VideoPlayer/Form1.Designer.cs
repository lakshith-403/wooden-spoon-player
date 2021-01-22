
namespace VideoPlayer
{
    partial class panel_player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panel_player));
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.input = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_send = new System.Windows.Forms.Button();
            this.txtin = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.chatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.ColumnCount = 2;
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panel_main.Controls.Add(this.input, 0, 0);
            this.panel_main.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.RowCount = 1;
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.Size = new System.Drawing.Size(1160, 389);
            this.panel_main.TabIndex = 1;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // input
            // 
            this.input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input.Enabled = true;
            this.input.Location = new System.Drawing.Point(3, 3);
            this.input.Name = "input";
            this.input.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("input.OcxState")));
            this.input.Size = new System.Drawing.Size(922, 383);
            this.input.TabIndex = 0;
            this.input.KeyPressEvent += new AxWMPLib._WMPOCXEvents_KeyPressEventHandler(this.axWindowsMediaPlayer1_KeyPressEvent);
            this.input.Enter += new System.EventHandler(this.player_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chatPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(931, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 383);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btn_send, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtin, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 308);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 32);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_send.Location = new System.Drawing.Point(201, 3);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(16, 26);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = ">";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txtin
            // 
            this.txtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtin.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtin.Location = new System.Drawing.Point(3, 3);
            this.txtin.Multiline = false;
            this.txtin.Name = "txtin";
            this.txtin.Size = new System.Drawing.Size(192, 26);
            this.txtin.TabIndex = 1;
            this.txtin.Text = "";
            this.txtin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtin_KeyPress);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btn_open, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_play, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_pause, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_close, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 346);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(220, 34);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btn_open
            // 
            this.btn_open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_open.Location = new System.Drawing.Point(3, 3);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(49, 28);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_play
            // 
            this.btn_play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_play.Location = new System.Drawing.Point(58, 3);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(49, 28);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pause.Location = new System.Drawing.Point(113, 3);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(49, 28);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(168, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(49, 28);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button6_Click);
            // 
            // chatPanel
            // 
            this.chatPanel.BackColor = System.Drawing.Color.White;
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatPanel.Location = new System.Drawing.Point(3, 33);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(220, 269);
            this.chatPanel.TabIndex = 4;
            // 
            // panel_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 668);
            this.Controls.Add(this.panel_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "panel_player";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_main;
        private AxWMPLib.AxWindowsMediaPlayer input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox txtin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.FlowLayoutPanel chatPanel;
    }
}

