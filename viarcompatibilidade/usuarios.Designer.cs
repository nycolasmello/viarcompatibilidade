
namespace viarcompatibilidade
{
    partial class usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.Senhatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Location = new System.Drawing.Point(60, 12);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.Size = new System.Drawing.Size(249, 23);
            this.Usuariotxt.TabIndex = 0;
            // 
            // Senhatxt
            // 
            this.Senhatxt.AcceptsReturn = true;
            this.Senhatxt.Location = new System.Drawing.Point(61, 54);
            this.Senhatxt.Name = "Senhatxt";
            this.Senhatxt.Size = new System.Drawing.Size(248, 23);
            this.Senhatxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(336, 116);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Senhatxt);
            this.Controls.Add(this.Usuariotxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Adicionar Roteadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.TextBox Senhatxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}