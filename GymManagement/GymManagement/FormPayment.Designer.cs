﻿namespace GymManagement
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.paymentsdg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.resetbtn = new System.Windows.Forms.Button();
            this.paymenybtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.totalpaymenttx = new System.Windows.Forms.TextBox();
            this.inputpaymenttx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsdg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentsdg
            // 
            this.paymentsdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsdg.Location = new System.Drawing.Point(372, 171);
            this.paymentsdg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentsdg.Name = "paymentsdg";
            this.paymentsdg.RowHeadersWidth = 62;
            this.paymentsdg.Size = new System.Drawing.Size(969, 457);
            this.paymentsdg.TabIndex = 0;
            this.paymentsdg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentsdg_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(357, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "Member Payments";
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.Plum;
            this.resetbtn.Location = new System.Drawing.Point(36, 490);
            this.resetbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(285, 49);
            this.resetbtn.TabIndex = 29;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // paymenybtn
            // 
            this.paymenybtn.BackColor = System.Drawing.Color.Thistle;
            this.paymenybtn.Location = new System.Drawing.Point(36, 417);
            this.paymenybtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymenybtn.Name = "paymenybtn";
            this.paymenybtn.Size = new System.Drawing.Size(285, 49);
            this.paymenybtn.TabIndex = 28;
            this.paymenybtn.Text = "Pay";
            this.paymenybtn.UseVisualStyleBackColor = false;
            this.paymenybtn.Click += new System.EventHandler(this.paymenybtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(32, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total Payments";
            // 
            // totalpaymenttx
            // 
            this.totalpaymenttx.Location = new System.Drawing.Point(38, 205);
            this.totalpaymenttx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalpaymenttx.Name = "totalpaymenttx";
            this.totalpaymenttx.ReadOnly = true;
            this.totalpaymenttx.Size = new System.Drawing.Size(283, 26);
            this.totalpaymenttx.TabIndex = 30;
            // 
            // inputpaymenttx
            // 
            this.inputpaymenttx.Location = new System.Drawing.Point(38, 306);
            this.inputpaymenttx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputpaymenttx.Name = "inputpaymenttx";
            this.inputpaymenttx.Size = new System.Drawing.Size(283, 26);
            this.inputpaymenttx.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(32, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Input Payments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkMagenta;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1283, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(241, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 109);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(729, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 109);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1392, 692);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputpaymenttx);
            this.Controls.Add(this.totalpaymenttx);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.paymenybtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentsdg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsdg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView paymentsdg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button paymenybtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalpaymenttx;
        private System.Windows.Forms.TextBox inputpaymenttx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}