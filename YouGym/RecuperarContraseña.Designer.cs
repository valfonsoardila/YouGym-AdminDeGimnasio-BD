
namespace YouGym
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.panelContenedorRecuperarContraseña = new System.Windows.Forms.Panel();
            this.labelCreaCuenta = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuSeparatorNombres = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenedorRecuperarContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnAtras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtras.IconSize = 25;
            this.btnAtras.Location = new System.Drawing.Point(5, 3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(24, 23);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panelContenedorRecuperarContraseña
            // 
            this.panelContenedorRecuperarContraseña.Controls.Add(this.panel1);
            this.panelContenedorRecuperarContraseña.Controls.Add(this.btnCrear);
            this.panelContenedorRecuperarContraseña.Controls.Add(this.bunifuSeparator1);
            this.panelContenedorRecuperarContraseña.Controls.Add(this.textBox2);
            this.panelContenedorRecuperarContraseña.Controls.Add(this.label1);
            this.panelContenedorRecuperarContraseña.Controls.Add(this.bunifuSeparatorNombres);
            this.panelContenedorRecuperarContraseña.Controls.Add(this.textBox1);
            this.panelContenedorRecuperarContraseña.Controls.Add(this.labelNombreUsuario);
            this.panelContenedorRecuperarContraseña.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorRecuperarContraseña.Name = "panelContenedorRecuperarContraseña";
            this.panelContenedorRecuperarContraseña.Size = new System.Drawing.Size(355, 358);
            this.panelContenedorRecuperarContraseña.TabIndex = 25;
            // 
            // labelCreaCuenta
            // 
            this.labelCreaCuenta.AutoSize = true;
            this.labelCreaCuenta.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreaCuenta.ForeColor = System.Drawing.Color.White;
            this.labelCreaCuenta.Location = new System.Drawing.Point(38, 40);
            this.labelCreaCuenta.Name = "labelCreaCuenta";
            this.labelCreaCuenta.Size = new System.Drawing.Size(241, 23);
            this.labelCreaCuenta.TabIndex = 25;
            this.labelCreaCuenta.Text = "RECUPERA TU CONTRASEÑA";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Location = new System.Drawing.Point(40, 114);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(99, 13);
            this.labelNombreUsuario.TabIndex = 26;
            this.labelNombreUsuario.Text = "Nombre de usuario:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(140, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 13);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bunifuSeparatorNombres
            // 
            this.bunifuSeparatorNombres.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparatorNombres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparatorNombres.BackgroundImage")));
            this.bunifuSeparatorNombres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparatorNombres.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparatorNombres.LineColor = System.Drawing.Color.Maroon;
            this.bunifuSeparatorNombres.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparatorNombres.LineThickness = 1;
            this.bunifuSeparatorNombres.Location = new System.Drawing.Point(139, 123);
            this.bunifuSeparatorNombres.Name = "bunifuSeparatorNombres";
            this.bunifuSeparatorNombres.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparatorNombres.Size = new System.Drawing.Size(152, 10);
            this.bunifuSeparatorNombres.TabIndex = 28;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Maroon;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(139, 154);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(152, 10);
            this.bunifuSeparator1.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(140, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 13);
            this.textBox2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Numero de ID:";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrear.Location = new System.Drawing.Point(91, 209);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(156, 23);
            this.btnCrear.TabIndex = 32;
            this.btnCrear.Text = "Recuperar Contraseña";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 28;
            this.iconPictureBox2.Location = new System.Drawing.Point(280, 36);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 49;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.labelCreaCuenta);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 100);
            this.panel1.TabIndex = 50;
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 358);
            this.Controls.Add(this.panelContenedorRecuperarContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecuperarContraseña";
            this.Text = "RecuperarContraseña";
            this.panelContenedorRecuperarContraseña.ResumeLayout(false);
            this.panelContenedorRecuperarContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAtras;
        private System.Windows.Forms.Panel panelContenedorRecuperarContraseña;
        private System.Windows.Forms.Label labelCreaCuenta;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparatorNombres;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}