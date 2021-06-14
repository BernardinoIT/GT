
namespace GT.Forms
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAssis = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAssis);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Location = new System.Drawing.Point(-10, -32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 373);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(152, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Entrar como:";
            // 
            // btnAssis
            // 
            this.btnAssis.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAssis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssis.FlatAppearance.BorderSize = 0;
            this.btnAssis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAssis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAssis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssis.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAssis.ForeColor = System.Drawing.Color.Transparent;
            this.btnAssis.Location = new System.Drawing.Point(153, 230);
            this.btnAssis.Name = "btnAssis";
            this.btnAssis.Size = new System.Drawing.Size(154, 48);
            this.btnAssis.TabIndex = 20;
            this.btnAssis.TabStop = false;
            this.btnAssis.Text = "Assistente Tecnico";
            this.btnAssis.UseVisualStyleBackColor = false;
            this.btnAssis.Click += new System.EventHandler(this.btnAssis_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Location = new System.Drawing.Point(153, 157);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(154, 48);
            this.btnAdmin.TabIndex = 19;
            this.btnAdmin.TabStop = false;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 332);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnAssis;
        internal System.Windows.Forms.Button btnAdmin;
    }
}