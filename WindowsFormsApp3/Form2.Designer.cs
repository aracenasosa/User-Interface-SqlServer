namespace WindowsFormsApp3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lastN = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IdentificationC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.NameT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.group = new System.Windows.Forms.GroupBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // lastN
            // 
            this.lastN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lastN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastN.ForeColor = System.Drawing.Color.DimGray;
            this.lastN.Location = new System.Drawing.Point(302, 173);
            this.lastN.Name = "lastN";
            this.lastN.Size = new System.Drawing.Size(127, 16);
            this.lastN.TabIndex = 1;
            this.lastN.Text = "LastName";
            this.lastN.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.lastN.Enter += new System.EventHandler(this.lastN_Enter);
            this.lastN.Leave += new System.EventHandler(this.lastN_Leave);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.DimGray;
            this.User.Location = new System.Drawing.Point(474, 107);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(127, 16);
            this.User.TabIndex = 2;
            this.User.Text = "Username";
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            this.User.Enter += new System.EventHandler(this.User_Enter);
            this.User.Leave += new System.EventHandler(this.User_Leave);
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.DimGray;
            this.Pass.Location = new System.Drawing.Point(475, 172);
            this.Pass.Multiline = true;
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(127, 17);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "Password";
            this.Pass.UseSystemPasswordChar = true;
            this.Pass.UseWaitCursor = true;
            this.Pass.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.Pass.Enter += new System.EventHandler(this.Pass_Enter);
            this.Pass.Leave += new System.EventHandler(this.Pass_Leave);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Female.Location = new System.Drawing.Point(47, 19);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(31, 17);
            this.Female.TabIndex = 5;
            this.Female.TabStop = true;
            this.Female.Text = "F";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(302, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(299, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(465, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(465, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(608, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(300, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "SignUp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(445, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IdentificationC
            // 
            this.IdentificationC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.IdentificationC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdentificationC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentificationC.ForeColor = System.Drawing.Color.DimGray;
            this.IdentificationC.Location = new System.Drawing.Point(468, 236);
            this.IdentificationC.Name = "IdentificationC";
            this.IdentificationC.Size = new System.Drawing.Size(127, 16);
            this.IdentificationC.TabIndex = 6;
            this.IdentificationC.Text = "Identification Card";
            this.IdentificationC.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.IdentificationC.Enter += new System.EventHandler(this.IdentificationC_Enter);
            this.IdentificationC.Leave += new System.EventHandler(this.IdentificationC_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(465, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cedula";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 450);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 450);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 468;
            this.lineShape5.X2 = 594;
            this.lineShape5.Y1 = 254;
            this.lineShape5.Y2 = 254;
            this.lineShape5.Click += new System.EventHandler(this.lineShape3_Click);
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 472;
            this.lineShape4.X2 = 598;
            this.lineShape4.Y1 = 192;
            this.lineShape4.Y2 = 192;
            this.lineShape4.Click += new System.EventHandler(this.lineShape3_Click);
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 473;
            this.lineShape3.X2 = 599;
            this.lineShape3.Y1 = 124;
            this.lineShape3.Y2 = 124;
            this.lineShape3.Click += new System.EventHandler(this.lineShape3_Click);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 302;
            this.lineShape2.X2 = 428;
            this.lineShape2.Y1 = 192;
            this.lineShape2.Y2 = 192;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 302;
            this.lineShape1.X2 = 427;
            this.lineShape1.Y1 = 125;
            this.lineShape1.Y2 = 125;
            this.lineShape1.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // NameT
            // 
            this.NameT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.NameT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameT.ForeColor = System.Drawing.Color.DimGray;
            this.NameT.Location = new System.Drawing.Point(302, 107);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(126, 16);
            this.NameT.TabIndex = 0;
            this.NameT.Text = "Name";
            this.NameT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.NameT.Enter += new System.EventHandler(this.textBox1_Enter);
            this.NameT.Leave += new System.EventHandler(this.Name_Leave);
            this.NameT.Validating += new System.ComponentModel.CancelEventHandler(this.NameT_Validating);
            this.NameT.Validated += new System.EventHandler(this.NameT_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(432, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "SignUp";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(782, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(751, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // group
            // 
            this.group.Controls.Add(this.Female);
            this.group.Controls.Add(this.Male);
            this.group.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.group.Location = new System.Drawing.Point(305, 217);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(81, 46);
            this.group.TabIndex = 22;
            this.group.TabStop = false;
            this.group.Text = "Sexo";
            this.group.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.Male.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Male.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Male.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Male.Location = new System.Drawing.Point(7, 19);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(34, 17);
            this.Male.TabIndex = 4;
            this.Male.TabStop = true;
            this.Male.Text = "M";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(257, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 46);
            this.button5.TabIndex = 23;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.group);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdentificationC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.lastN);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Opacity = 0.85D;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lastN;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IdentificationC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox NameT;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Button button5;
    }
}