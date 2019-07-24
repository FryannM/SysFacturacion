namespace CapaPresentacion
{
    partial class frmSelectSucursal
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.cboDirSucursal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "SELECCIONAR SUCURSAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Image = global::CapaPresentacion.Properties.Resources.accept_16x16_32;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.Location = new System.Drawing.Point(184, 204);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(98, 46);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "INICIAR";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cboDirSucursal
            // 
            this.cboDirSucursal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboDirSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDirSucursal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.cboDirSucursal.FormattingEnabled = true;
            this.cboDirSucursal.Location = new System.Drawing.Point(12, 121);
            this.cboDirSucursal.Name = "cboDirSucursal";
            this.cboDirSucursal.Size = new System.Drawing.Size(474, 23);
            this.cboDirSucursal.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 56);
            this.label3.TabIndex = 23;
            this.label3.Text = "Seleccionar sucursal a trabajar, para tener un control de la informacion y saber " +
    "sobre la cual se realizaron las acciones.";
            // 
            // frmSelectSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(498, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDirSucursal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIngresar);
            this.MaximumSize = new System.Drawing.Size(514, 300);
            this.MinimumSize = new System.Drawing.Size(514, 300);
            this.Name = "frmSelectSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUCURSAL";
            this.Load += new System.EventHandler(this.frmSelectSucursal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ComboBox cboDirSucursal;
        private System.Windows.Forms.Label label3;
    }
}