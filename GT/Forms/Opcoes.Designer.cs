
namespace GT.Forms
{
    partial class Opcoes
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnElimCli = new System.Windows.Forms.Button();
            this.btnCadPre = new System.Windows.Forms.Button();
            this.btnCadPos = new System.Windows.Forms.Button();
            this.btnNrCli = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnElimCli);
            this.panel1.Controls.Add(this.btnCadPre);
            this.panel1.Controls.Add(this.btnCadPos);
            this.panel1.Controls.Add(this.btnNrCli);
            this.panel1.Location = new System.Drawing.Point(-7, -30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 373);
            this.panel1.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(7, 345);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnElimCli
            // 
            this.btnElimCli.BackColor = System.Drawing.Color.DarkCyan;
            this.btnElimCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElimCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElimCli.FlatAppearance.BorderSize = 0;
            this.btnElimCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnElimCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnElimCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimCli.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold);
            this.btnElimCli.ForeColor = System.Drawing.Color.Transparent;
            this.btnElimCli.Location = new System.Drawing.Point(169, 260);
            this.btnElimCli.Name = "btnElimCli";
            this.btnElimCli.Size = new System.Drawing.Size(136, 40);
            this.btnElimCli.TabIndex = 25;
            this.btnElimCli.TabStop = false;
            this.btnElimCli.Text = "Eliminar cliente";
            this.btnElimCli.UseVisualStyleBackColor = false;
            this.btnElimCli.Click += new System.EventHandler(this.btnElimCli_Click);
            // 
            // btnCadPre
            // 
            this.btnCadPre.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCadPre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadPre.FlatAppearance.BorderSize = 0;
            this.btnCadPre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadPre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCadPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadPre.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold);
            this.btnCadPre.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadPre.Location = new System.Drawing.Point(169, 138);
            this.btnCadPre.Name = "btnCadPre";
            this.btnCadPre.Size = new System.Drawing.Size(136, 40);
            this.btnCadPre.TabIndex = 24;
            this.btnCadPre.TabStop = false;
            this.btnCadPre.Text = "Cadastrar cientes Pos-Pago";
            this.btnCadPre.UseVisualStyleBackColor = false;
            this.btnCadPre.Click += new System.EventHandler(this.btnCadPre_Click);
            // 
            // btnCadPos
            // 
            this.btnCadPos.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCadPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadPos.FlatAppearance.BorderSize = 0;
            this.btnCadPos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadPos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCadPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadPos.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold);
            this.btnCadPos.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadPos.Location = new System.Drawing.Point(169, 79);
            this.btnCadPos.Name = "btnCadPos";
            this.btnCadPos.Size = new System.Drawing.Size(136, 36);
            this.btnCadPos.TabIndex = 23;
            this.btnCadPos.TabStop = false;
            this.btnCadPos.Text = "Cadastrar cientes Pre-Pago";
            this.btnCadPos.UseVisualStyleBackColor = false;
            this.btnCadPos.Click += new System.EventHandler(this.btnCadPos_Click);
            // 
            // btnNrCli
            // 
            this.btnNrCli.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNrCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNrCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNrCli.FlatAppearance.BorderSize = 0;
            this.btnNrCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNrCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNrCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNrCli.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold);
            this.btnNrCli.ForeColor = System.Drawing.Color.Transparent;
            this.btnNrCli.Location = new System.Drawing.Point(169, 199);
            this.btnNrCli.Name = "btnNrCli";
            this.btnNrCli.Size = new System.Drawing.Size(136, 41);
            this.btnNrCli.TabIndex = 22;
            this.btnNrCli.TabStop = false;
            this.btnNrCli.Text = "Ver numero de clientes registrados";
            this.btnNrCli.UseVisualStyleBackColor = false;
            this.btnNrCli.Click += new System.EventHandler(this.btnNrCli_Click);
            // 
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 336);
            this.Controls.Add(this.panel1);
            this.Name = "Opcoes";
            this.Text = "OpAdmin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnCadPre;
        internal System.Windows.Forms.Button btnCadPos;
        internal System.Windows.Forms.Button btnNrCli;
        internal System.Windows.Forms.Button btnElimCli;
        private System.Windows.Forms.Button btnVoltar;
    }
}