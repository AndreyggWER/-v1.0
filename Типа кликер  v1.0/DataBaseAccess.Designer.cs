namespace Типа_кликер__v1._0
{
    partial class DataBaseAccess
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
            this.TextBoxServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxDataBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxServer
            // 
            this.TextBoxServer.Location = new System.Drawing.Point(74, 9);
            this.TextBoxServer.Name = "TextBoxServer";
            this.TextBoxServer.Size = new System.Drawing.Size(100, 20);
            this.TextBoxServer.TabIndex = 0;
            this.TextBoxServer.Text = "localhost";
            this.TextBoxServer.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Location = new System.Drawing.Point(74, 35);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPort.TabIndex = 2;
            this.TextBoxPort.Text = "3306";
            this.TextBoxPort.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(74, 61);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxUserName.TabIndex = 4;
            this.TextBoxUserName.Text = "root";
            this.TextBoxUserName.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(74, 87);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPassword.TabIndex = 6;
            this.TextBoxPassword.Text = "root";
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "DataBase";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxDataBase
            // 
            this.TextBoxDataBase.Location = new System.Drawing.Point(74, 113);
            this.TextBoxDataBase.Name = "TextBoxDataBase";
            this.TextBoxDataBase.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDataBase.TabIndex = 8;
            this.TextBoxDataBase.Text = "ocenki";
            this.TextBoxDataBase.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // DataBaseAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 144);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxDataBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxServer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataBaseAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DataBaseAccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxDataBase;
    }
}