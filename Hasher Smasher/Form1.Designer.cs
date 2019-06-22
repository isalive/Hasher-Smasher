namespace Hasher_Smasher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbkeyinput = new System.Windows.Forms.TextBox();
            this.tbinput = new System.Windows.Forms.TextBox();
            this.btencrypt = new System.Windows.Forms.Button();
            this.btdecrypt = new System.Windows.Forms.Button();
            this.tboutput = new System.Windows.Forms.TextBox();
            this.btclearall = new System.Windows.Forms.Button();
            this.btcopyinput = new System.Windows.Forms.Button();
            this.btcopyoutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbkeyinput
            // 
            this.tbkeyinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbkeyinput.Location = new System.Drawing.Point(94, 12);
            this.tbkeyinput.Name = "tbkeyinput";
            this.tbkeyinput.Size = new System.Drawing.Size(214, 31);
            this.tbkeyinput.TabIndex = 0;
            this.tbkeyinput.UseSystemPasswordChar = true;
            // 
            // tbinput
            // 
            this.tbinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbinput.Location = new System.Drawing.Point(12, 49);
            this.tbinput.Name = "tbinput";
            this.tbinput.Size = new System.Drawing.Size(356, 31);
            this.tbinput.TabIndex = 1;
            this.tbinput.Text = "Insert String to Encrypt";
            this.tbinput.Click += new System.EventHandler(this.Tbinput_Click);
            this.tbinput.Leave += new System.EventHandler(this.Tbinput_Leave);
            // 
            // btencrypt
            // 
            this.btencrypt.Location = new System.Drawing.Point(12, 127);
            this.btencrypt.Name = "btencrypt";
            this.btencrypt.Size = new System.Drawing.Size(139, 56);
            this.btencrypt.TabIndex = 2;
            this.btencrypt.Text = "Check-Encrypt";
            this.btencrypt.UseVisualStyleBackColor = true;
            this.btencrypt.Click += new System.EventHandler(this.Btencrypt_Click);
            // 
            // btdecrypt
            // 
            this.btdecrypt.Location = new System.Drawing.Point(266, 127);
            this.btdecrypt.Name = "btdecrypt";
            this.btdecrypt.Size = new System.Drawing.Size(139, 56);
            this.btdecrypt.TabIndex = 3;
            this.btdecrypt.Text = "Decrypt";
            this.btdecrypt.UseVisualStyleBackColor = true;
            this.btdecrypt.Click += new System.EventHandler(this.Btdecrypt_Click);
            // 
            // tboutput
            // 
            this.tboutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboutput.Location = new System.Drawing.Point(12, 86);
            this.tboutput.Name = "tboutput";
            this.tboutput.Size = new System.Drawing.Size(356, 31);
            this.tboutput.TabIndex = 4;
            this.tboutput.Text = "Insert String to Decrypt";
            this.tboutput.Click += new System.EventHandler(this.Tboutput_Click);
            this.tboutput.Leave += new System.EventHandler(this.Tboutput_Leave);
            // 
            // btclearall
            // 
            this.btclearall.Location = new System.Drawing.Point(157, 127);
            this.btclearall.Name = "btclearall";
            this.btclearall.Size = new System.Drawing.Size(103, 56);
            this.btclearall.TabIndex = 5;
            this.btclearall.Text = "Clear All";
            this.btclearall.UseVisualStyleBackColor = true;
            this.btclearall.Click += new System.EventHandler(this.Btclearall_Click);
            // 
            // btcopyinput
            // 
            this.btcopyinput.Location = new System.Drawing.Point(371, 49);
            this.btcopyinput.Name = "btcopyinput";
            this.btcopyinput.Size = new System.Drawing.Size(40, 31);
            this.btcopyinput.TabIndex = 6;
            this.btcopyinput.Text = "C";
            this.btcopyinput.UseVisualStyleBackColor = true;
            this.btcopyinput.Click += new System.EventHandler(this.Btcopyinput_Click);
            // 
            // btcopyoutput
            // 
            this.btcopyoutput.Location = new System.Drawing.Point(371, 86);
            this.btcopyoutput.Name = "btcopyoutput";
            this.btcopyoutput.Size = new System.Drawing.Size(40, 31);
            this.btcopyoutput.TabIndex = 7;
            this.btcopyoutput.Text = "C";
            this.btcopyoutput.UseVisualStyleBackColor = true;
            this.btcopyoutput.Click += new System.EventHandler(this.Btcopyoutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 195);
            this.Controls.Add(this.btcopyoutput);
            this.Controls.Add(this.btcopyinput);
            this.Controls.Add(this.btclearall);
            this.Controls.Add(this.tboutput);
            this.Controls.Add(this.btdecrypt);
            this.Controls.Add(this.btencrypt);
            this.Controls.Add(this.tbinput);
            this.Controls.Add(this.tbkeyinput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HasherSmasher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbkeyinput;
        private System.Windows.Forms.TextBox tbinput;
        private System.Windows.Forms.Button btencrypt;
        private System.Windows.Forms.Button btdecrypt;
        private System.Windows.Forms.TextBox tboutput;
        private System.Windows.Forms.Button btclearall;
        private System.Windows.Forms.Button btcopyinput;
        private System.Windows.Forms.Button btcopyoutput;
    }
}

