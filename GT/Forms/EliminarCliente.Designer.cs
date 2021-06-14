
namespace GT.Forms
{
    partial class EliminarCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnElimPos = new System.Windows.Forms.Button();
            this.btnElimPre = new System.Windows.Forms.Button();
            this.txtNrTel = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnElimPos);
            this.panel1.Controls.Add(this.btnElimPre);
            this.panel1.Controls.Add(this.txtNrTel);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Location = new System.Drawing.Point(-6, -29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 370);
            this.panel1.TabIndex = 0;
            // 
            // btnElimPos
            // 
            this.btnElimPos.BackColor = System.Drawing.Color.DarkCyan;
            this.btnElimPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElimPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElimPos.FlatAppearance.BorderSize = 0;
            this.btnElimPos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnElimPos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnElimPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimPos.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold);
            this.btnElimPos.ForeColor = System.Drawing.Color.Transparent;
            this.btnElimPos.Location = new System.Drawing.Point(226, 233);
            this.btnElimPos.Name = "btnElimPos";
            this.btnElimPos.Size = new System.Drawing.Size(87, 34);
            this.btnElimPos.TabIndex = 60;
            this.btnElimPos.TabStop = false;
            this.btnElimPos.Text = "Eliminar cliente pre-pago";
            this.btnElimPos.UseVisualStyleBackColor = false;
            this.btnElimPos.Click += new System.EventHandler(this.btnElimPos_Click);
            // 
            // btnElimPre
            // 
            this.btnElimPre.BackColor = System.Drawing.Color.DarkCyan;
            this.btnElimPre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElimPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElimPre.FlatAppearance.BorderSize = 0;
            this.btnElimPre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnElimPre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnElimPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimPre.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold);
            this.btnElimPre.ForeColor = System.Drawing.Color.Transparent;
            this.btnElimPre.Location = new System.Drawing.Point(133, 233);
            this.btnElimPre.Name = "btnElimPre";
            this.btnElimPre.Size = new System.Drawing.Size(87, 34);
            this.btnElimPre.TabIndex = 59;
            this.btnElimPre.TabStop = false;
            this.btnElimPre.Text = "Eliminar cliente pre-pago";
            this.btnElimPre.UseVisualStyleBackColor = false;
            this.btnElimPre.Click += new System.EventHandler(this.btnElimPre_Click);
            // 
            // txtNrTel
            // 
            this.txtNrTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.txtNrTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNrTel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.txtNrTel.Location = new System.Drawing.Point(165, 155);
            this.txtNrTel.Name = "txtNrTel";
            this.txtNrTel.Size = new System.Drawing.Size(117, 16);
            this.txtNrTel.TabIndex = 58;
            this.txtNrTel.Text = "Numero de telefone";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(133, 149);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(180, 28);
            this.pictureBox6.TabIndex = 57;
            this.pictureBox6.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.Label1.Location = new System.Drawing.Point(164, 81);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(113, 17);
            this.Label1.TabIndex = 56;
            this.Label1.Text = "Eliminar cliente";
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 335);
            this.Controls.Add(this.panel1);
            this.Name = "EliminarCliente";
            this.Text = "EliminarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TextBox txtNrTel;
        internal System.Windows.Forms.PictureBox pictureBox6;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnElimPos;
        internal System.Windows.Forms.Button btnElimPre;
    }
}