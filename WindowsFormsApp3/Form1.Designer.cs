namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(44, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 280;
            this.lineShape2.X2 = 713;
            this.lineShape2.Y1 = 167;
            this.lineShape2.Y2 = 167;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 280;
            this.lineShape1.X2 = 713;
            this.lineShape1.Y1 = 94;
            this.lineShape1.Y2 = 94;
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.DimGray;
            this.user.Location = new System.Drawing.Point(280, 71);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(434, 20);
            this.user.TabIndex = 1;
            this.user.Text = "Username";
            this.user.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.user.Enter += new System.EventHandler(this.textBox1_Enter);
            this.user.Leave += new System.EventHandler(this.user_Leave);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.DimGray;
            this.pass.Location = new System.Drawing.Point(280, 139);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(434, 20);
            this.pass.TabIndex = 2;
            this.pass.Text = "Password";
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            this.pass.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.login.Location = new System.Drawing.Point(280, 219);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(434, 42);
            this.login.TabIndex = 3;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(347, 281);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(235, 21);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Ha olvidado la contraseña?";
            // 
            // cerrar
            // 
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(762, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(15, 15);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 9;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(741, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(15, 15);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 10;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

