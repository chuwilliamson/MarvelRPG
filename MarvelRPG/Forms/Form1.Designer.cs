﻿namespace MarvelRPG
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.classGroupBox1 = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.partyBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.webTextBox1 = new System.Windows.Forms.TextBox();
            this.clearParty_button = new System.Windows.Forms.Button();
            this.start_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.classGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = global::MarvelRPG.Properties.Resources.Hulk_small;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // classGroupBox1
            // 
            this.classGroupBox1.Controls.Add(this.removeButton);
            this.classGroupBox1.Controls.Add(this.addButton);
            this.classGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classGroupBox1.Location = new System.Drawing.Point(637, 12);
            this.classGroupBox1.Name = "classGroupBox1";
            this.classGroupBox1.Size = new System.Drawing.Size(115, 302);
            this.classGroupBox1.TabIndex = 1;
            this.classGroupBox1.TabStop = false;
            this.classGroupBox1.Text = "Class";
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(6, 271);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(103, 25);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(6, 240);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 25);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // partyBox
            // 
            this.partyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyBox.Location = new System.Drawing.Point(782, 12);
            this.partyBox.Name = "partyBox";
            this.partyBox.Size = new System.Drawing.Size(115, 234);
            this.partyBox.TabIndex = 7;
            this.partyBox.TabStop = false;
            this.partyBox.Text = "Party";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(788, 252);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 25);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(788, 283);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(103, 25);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // webTextBox1
            // 
            this.webTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webTextBox1.Location = new System.Drawing.Point(316, 12);
            this.webTextBox1.Multiline = true;
            this.webTextBox1.Name = "webTextBox1";
            this.webTextBox1.ReadOnly = true;
            this.webTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.webTextBox1.Size = new System.Drawing.Size(283, 592);
            this.webTextBox1.TabIndex = 6;
            // 
            // clearParty_button
            // 
            this.clearParty_button.Location = new System.Drawing.Point(788, 314);
            this.clearParty_button.Name = "clearParty_button";
            this.clearParty_button.Size = new System.Drawing.Size(103, 25);
            this.clearParty_button.TabIndex = 10;
            this.clearParty_button.Text = "Clear Party";
            this.clearParty_button.UseVisualStyleBackColor = true;
            this.clearParty_button.Click += new System.EventHandler(this.clearParty_button_Click);
            // 
            // start_Button
            // 
            this.start_Button.BackColor = System.Drawing.SystemColors.Control;
            this.start_Button.Location = new System.Drawing.Point(637, 345);
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(260, 265);
            this.start_Button.TabIndex = 11;
            this.start_Button.Text = "Start";
            this.start_Button.UseVisualStyleBackColor = false;
            this.start_Button.Click += new System.EventHandler(this.start_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 862);
            this.Controls.Add(this.start_Button);
            this.Controls.Add(this.clearParty_button);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.webTextBox1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.partyBox);
            this.Controls.Add(this.classGroupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Selection";
            this.Load += new System.EventHandler(this.Form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.classGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox classGroupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox partyBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox webTextBox1;
        private System.Windows.Forms.Button clearParty_button;
        private System.Windows.Forms.Button start_Button;
    }
}
