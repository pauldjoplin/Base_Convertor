namespace Section2Project
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnEleven = new System.Windows.Forms.Button();
            this.lblConvert = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(12, 218);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(237, 20);
            this.txtBase.TabIndex = 0;
            this.txtBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // txtConvert
            // 
            this.txtConvert.Location = new System.Drawing.Point(12, 70);
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(237, 20);
            this.txtConvert.TabIndex = 1;
            this.txtConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConvert.TextChanged += new System.EventHandler(this.txtConvert_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(289, 40);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(439, 260);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(12, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(672, 445);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.BackColor = System.Drawing.Color.Silver;
            this.btnBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinary.Location = new System.Drawing.Point(292, 333);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(99, 33);
            this.btnBinary.TabIndex = 5;
            this.btnBinary.Text = "Binary";
            this.btnBinary.UseVisualStyleBackColor = false;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnHex
            // 
            this.btnHex.BackColor = System.Drawing.Color.Silver;
            this.btnHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHex.Location = new System.Drawing.Point(292, 397);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(99, 33);
            this.btnHex.TabIndex = 6;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = false;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnOctal
            // 
            this.btnOctal.BackColor = System.Drawing.Color.Silver;
            this.btnOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOctal.Location = new System.Drawing.Point(465, 333);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(99, 33);
            this.btnOctal.TabIndex = 7;
            this.btnOctal.Text = "Octal";
            this.btnOctal.UseVisualStyleBackColor = false;
            this.btnOctal.Click += new System.EventHandler(this.btnOctal_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Silver;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(465, 397);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(99, 33);
            this.btnSix.TabIndex = 8;
            this.btnSix.Text = "Base 6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnEleven
            // 
            this.btnEleven.BackColor = System.Drawing.Color.Silver;
            this.btnEleven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEleven.Location = new System.Drawing.Point(629, 360);
            this.btnEleven.Name = "btnEleven";
            this.btnEleven.Size = new System.Drawing.Size(99, 33);
            this.btnEleven.TabIndex = 9;
            this.btnEleven.Text = "Base 11";
            this.btnEleven.UseVisualStyleBackColor = false;
            this.btnEleven.Click += new System.EventHandler(this.btnEleven_Click);
            // 
            // lblConvert
            // 
            this.lblConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvert.Location = new System.Drawing.Point(12, 40);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(237, 27);
            this.lblConvert.TabIndex = 10;
            this.lblConvert.Text = "Convert from";
            this.lblConvert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConvert.Click += new System.EventHandler(this.lblConvert_Click);
            // 
            // lblBase
            // 
            this.lblBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(12, 192);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(237, 23);
            this.lblBase.TabIndex = 11;
            this.lblBase.Text = "Base 2-16 (If using Convert To)";
            this.lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBase.Click += new System.EventHandler(this.lblBase_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Silver;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(83, 267);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(99, 33);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "Convert To";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(777, 489);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblConvert);
            this.Controls.Add(this.btnEleven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.txtBase);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHeisenberg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtConvert;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnEleven;
        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Button btnConvert;
    }
}

