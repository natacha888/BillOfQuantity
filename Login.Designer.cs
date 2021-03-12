namespace BillOfQuantity
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.titre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.agent = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.TextBox();
            this.savePassword = new System.Windows.Forms.CheckBox();
            this.defaultProfile = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.locateButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(115, 26);
            this.titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(302, 48);
            this.titre.TabIndex = 0;
            this.titre.Text = "Bill Of Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // agent
            // 
            this.agent.FormattingEnabled = true;
            this.agent.Location = new System.Drawing.Point(151, 114);
            this.agent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.agent.Name = "agent";
            this.agent.Size = new System.Drawing.Size(287, 24);
            this.agent.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(151, 165);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(287, 22);
            this.password.TabIndex = 4;
            // 
            // savePassword
            // 
            this.savePassword.AutoSize = true;
            this.savePassword.Location = new System.Drawing.Point(151, 218);
            this.savePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savePassword.Name = "savePassword";
            this.savePassword.Size = new System.Drawing.Size(127, 21);
            this.savePassword.TabIndex = 5;
            this.savePassword.Text = "Save Password";
            this.savePassword.UseVisualStyleBackColor = true;
            // 
            // defaultProfile
            // 
            this.defaultProfile.AutoSize = true;
            this.defaultProfile.Enabled = false;
            this.defaultProfile.Location = new System.Drawing.Point(320, 218);
            this.defaultProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.defaultProfile.Name = "defaultProfile";
            this.defaultProfile.Size = new System.Drawing.Size(119, 21);
            this.defaultProfile.TabIndex = 6;
            this.defaultProfile.Text = "Default Profile";
            this.defaultProfile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newButton);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.locateButton);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(47, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(460, 169);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Databases";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(319, 130);
            this.newButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(133, 28);
            this.newButton.TabIndex = 4;
            this.newButton.Text = "New...";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(319, 95);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(133, 28);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(319, 59);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(133, 28);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit...";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // locateButton
            // 
            this.locateButton.Location = new System.Drawing.Point(319, 23);
            this.locateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.locateButton.Name = "locateButton";
            this.locateButton.Size = new System.Drawing.Size(133, 28);
            this.locateButton.TabIndex = 1;
            this.locateButton.Text = "Locate...";
            this.locateButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 23);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(301, 132);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "\n\n\n                               Please select \"Locate\"\n                        " +
    "                          or  \n                                        \"New\"";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(108, 466);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(257, 466);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(407, 466);
            this.optionsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(100, 28);
            this.optionsButton.TabIndex = 10;
            this.optionsButton.Text = "<<Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 513);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.defaultProfile);
            this.Controls.Add(this.savePassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.agent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login to BillOfQuantity";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox agent;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox savePassword;
        private System.Windows.Forms.CheckBox defaultProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button locateButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button optionsButton;
    }
}

