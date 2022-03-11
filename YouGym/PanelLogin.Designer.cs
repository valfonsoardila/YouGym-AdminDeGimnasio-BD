
namespace YouGym
{
    partial class PanelLogin
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
            this.Minimizar = new FontAwesome.Sharp.IconButton();
            this.Salir = new FontAwesome.Sharp.IconButton();
            this.panelBarraDeOpciones = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelBarraDeOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.FlatAppearance.BorderSize = 0;
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Minimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimizar.IconSize = 25;
            this.Minimizar.Location = new System.Drawing.Point(299, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(24, 23);
            this.Minimizar.TabIndex = 5;
            this.Minimizar.UseVisualStyleBackColor = true;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.Salir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Salir.IconSize = 28;
            this.Salir.Location = new System.Drawing.Point(326, 5);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(24, 23);
            this.Salir.TabIndex = 4;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // panelBarraDeOpciones
            // 
            this.panelBarraDeOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.panelBarraDeOpciones.Controls.Add(this.Minimizar);
            this.panelBarraDeOpciones.Controls.Add(this.Salir);
            this.panelBarraDeOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelBarraDeOpciones.Name = "panelBarraDeOpciones";
            this.panelBarraDeOpciones.Size = new System.Drawing.Size(355, 32);
            this.panelBarraDeOpciones.TabIndex = 1;
            this.panelBarraDeOpciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraDeOpciones_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(0, 32);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(355, 357);
            this.panelContenedor.TabIndex = 2;
            // 
            // PanelLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 388);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarraDeOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelLogin";
            this.Text = "Login1";
            this.panelBarraDeOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Minimizar;
        private FontAwesome.Sharp.IconButton Salir;
        private System.Windows.Forms.Panel panelBarraDeOpciones;
        private System.Windows.Forms.Panel panelContenedor;
    }
}