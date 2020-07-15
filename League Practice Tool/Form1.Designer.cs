namespace League_Practice_Tool
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.CreateLobby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateLobby
            // 
            this.CreateLobby.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateLobby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateLobby.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateLobby.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateLobby.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLobby.Location = new System.Drawing.Point(33, 17);
            this.CreateLobby.Name = "CreateLobby";
            this.CreateLobby.Size = new System.Drawing.Size(238, 89);
            this.CreateLobby.TabIndex = 0;
            this.CreateLobby.Text = "Create Lobby";
            this.CreateLobby.UseVisualStyleBackColor = false;
            this.CreateLobby.Click += new System.EventHandler(this.button1_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(304, 121);
            this.Controls.Add(this.CreateLobby);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice Tool - MManoah";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateLobby;
    }
}

