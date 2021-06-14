
namespace GT.Forms
{
    partial class QntCli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gTelefoniaDataSet = new GT.GTelefoniaDataSet();
            this.gTelefoniaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTelefoniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTelefoniaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPos);
            this.panel1.Controls.Add(this.btnVer);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-8, -31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 376);
            this.panel1.TabIndex = 0;
            // 
            // btnPos
            // 
            this.btnPos.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPos.FlatAppearance.BorderSize = 0;
            this.btnPos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold);
            this.btnPos.ForeColor = System.Drawing.Color.Transparent;
            this.btnPos.Location = new System.Drawing.Point(340, 60);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(108, 28);
            this.btnPos.TabIndex = 26;
            this.btnPos.TabStop = false;
            this.btnPos.Text = "Clientes Pos-Pago";
            this.btnPos.UseVisualStyleBackColor = false;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold);
            this.btnVer.ForeColor = System.Drawing.Color.Transparent;
            this.btnVer.Location = new System.Drawing.Point(221, 60);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(113, 28);
            this.btnVer.TabIndex = 25;
            this.btnVer.TabStop = false;
            this.btnVer.Text = "Clientes Pre-Pago";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.Label1.Location = new System.Drawing.Point(7, 66);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(152, 17);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Clientes Cadastrados";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(10, 348);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.gTelefoniaDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // gTelefoniaDataSet
            // 
            this.gTelefoniaDataSet.DataSetName = "GTelefoniaDataSet";
            this.gTelefoniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gTelefoniaDataSetBindingSource
            // 
            this.gTelefoniaDataSetBindingSource.DataSource = this.gTelefoniaDataSet;
            this.gTelefoniaDataSetBindingSource.Position = 0;
            // 
            // QntCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 338);
            this.Controls.Add(this.panel1);
            this.Name = "QntCli";
            this.Text = "QntCli";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTelefoniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTelefoniaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVoltar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnVer;
        internal System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.BindingSource gTelefoniaDataSetBindingSource;
        private GTelefoniaDataSet gTelefoniaDataSet;
    }
}