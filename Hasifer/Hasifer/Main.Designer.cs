namespace Hasifer
{
    partial class Main
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
            this.lnkCredits = new MetroFramework.Controls.MetroLink();
            this.tbHashIdentifier = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtHash = new MetroFramework.Controls.MetroTextBox();
            this.txtIdentity = new MetroFramework.Controls.MetroTextBox();
            this.btnIdentify = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbHashIdentifier.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkCredits
            // 
            this.lnkCredits.Location = new System.Drawing.Point(316, 202);
            this.lnkCredits.Name = "lnkCredits";
            this.lnkCredits.Size = new System.Drawing.Size(197, 23);
            this.lnkCredits.TabIndex = 0;
            this.lnkCredits.Text = "Copyright © 2015, Scarecrow [CK]";
            this.lnkCredits.Click += new System.EventHandler(this.lnkCredits_Click);
            // 
            // tbHashIdentifier
            // 
            this.tbHashIdentifier.Controls.Add(this.metroTabPage1);
            this.tbHashIdentifier.Controls.Add(this.metroTabPage2);
            this.tbHashIdentifier.Location = new System.Drawing.Point(23, 63);
            this.tbHashIdentifier.Name = "tbHashIdentifier";
            this.tbHashIdentifier.SelectedIndex = 1;
            this.tbHashIdentifier.Size = new System.Drawing.Size(490, 133);
            this.tbHashIdentifier.TabIndex = 1;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.btnClear);
            this.metroTabPage1.Controls.Add(this.btnIdentify);
            this.metroTabPage1.Controls.Add(this.txtIdentity);
            this.metroTabPage1.Controls.Add(this.txtHash);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(482, 94);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "General";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(482, 94);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "About";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(68, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Your Hash";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(142, 11);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(337, 20);
            this.txtHash.TabIndex = 3;
            // 
            // txtIdentity
            // 
            this.txtIdentity.Location = new System.Drawing.Point(142, 37);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(337, 23);
            this.txtIdentity.TabIndex = 4;
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(142, 66);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(66, 23);
            this.btnIdentify.TabIndex = 5;
            this.btnIdentify.Text = "Identify";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(214, 66);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Possible Identification";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(110, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(258, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Created by Scarecrow | Sins, CrackingKing!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 236);
            this.Controls.Add(this.tbHashIdentifier);
            this.Controls.Add(this.lnkCredits);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "Hasifer - Hash Identifier";
            this.tbHashIdentifier.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkCredits;
        private MetroFramework.Controls.MetroTabControl tbHashIdentifier;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox txtHash;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnIdentify;
        private MetroFramework.Controls.MetroTextBox txtIdentity;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

