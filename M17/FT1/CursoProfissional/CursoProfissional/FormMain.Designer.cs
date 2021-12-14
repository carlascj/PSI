
namespace CursoProfissional
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.miDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.miSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogoAERP = new System.Windows.Forms.PictureBox();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoAERP)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miInserir,
            this.miSair});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(1028, 24);
            this.msMain.TabIndex = 0;
            // 
            // miInserir
            // 
            this.miInserir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDisciplina});
            this.miInserir.Name = "miInserir";
            this.miInserir.Size = new System.Drawing.Size(51, 20);
            this.miInserir.Text = "Inserir";
            // 
            // miDisciplina
            // 
            this.miDisciplina.Name = "miDisciplina";
            this.miDisciplina.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.miDisciplina.Size = new System.Drawing.Size(180, 22);
            this.miDisciplina.Text = "Disciplina";
            this.miDisciplina.Click += new System.EventHandler(this.miDisciplina_Click);
            // 
            // miSair
            // 
            this.miSair.Name = "miSair";
            this.miSair.Size = new System.Drawing.Size(38, 20);
            this.miSair.Text = "Sair";
            this.miSair.Click += new System.EventHandler(this.miSair_Click);
            // 
            // pbLogoAERP
            // 
            this.pbLogoAERP.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoAERP.Image")));
            this.pbLogoAERP.Location = new System.Drawing.Point(9, 45);
            this.pbLogoAERP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogoAERP.Name = "pbLogoAERP";
            this.pbLogoAERP.Size = new System.Drawing.Size(1005, 297);
            this.pbLogoAERP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogoAERP.TabIndex = 1;
            this.pbLogoAERP.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1028, 368);
            this.Controls.Add(this.pbLogoAERP);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPTGPSI";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoAERP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miInserir;
        private System.Windows.Forms.ToolStripMenuItem miDisciplina;
        private System.Windows.Forms.PictureBox pbLogoAERP;
        private System.Windows.Forms.ToolStripMenuItem miSair;
    }
}

