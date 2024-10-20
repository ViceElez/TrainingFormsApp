
namespace nova_aplikacija
{
    partial class Form3
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
            this.gbVjezbe = new System.Windows.Forms.GroupBox();
            this.lsbListaVjezbi = new System.Windows.Forms.ListBox();
            this.btnDodajNovuVjezbu = new System.Windows.Forms.Button();
            this.gbVjezbe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVjezbe
            // 
            this.gbVjezbe.BackgroundImage = global::nova_aplikacija.Properties.Resources.Old_dumbbells_on_white;
            this.gbVjezbe.Controls.Add(this.lsbListaVjezbi);
            this.gbVjezbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gbVjezbe.ForeColor = System.Drawing.Color.Red;
            this.gbVjezbe.Location = new System.Drawing.Point(23, 12);
            this.gbVjezbe.Name = "gbVjezbe";
            this.gbVjezbe.Size = new System.Drawing.Size(474, 366);
            this.gbVjezbe.TabIndex = 1;
            this.gbVjezbe.TabStop = false;
            this.gbVjezbe.Text = "Vjezbe";
            // 
            // lsbListaVjezbi
            // 
            this.lsbListaVjezbi.ForeColor = System.Drawing.Color.Red;
            this.lsbListaVjezbi.FormattingEnabled = true;
            this.lsbListaVjezbi.ItemHeight = 25;
            this.lsbListaVjezbi.Location = new System.Drawing.Point(18, 29);
            this.lsbListaVjezbi.Name = "lsbListaVjezbi";
            this.lsbListaVjezbi.Size = new System.Drawing.Size(379, 254);
            this.lsbListaVjezbi.TabIndex = 0;
            this.lsbListaVjezbi.SelectedIndexChanged += new System.EventHandler(this.lsbListaVjezbi_SelectedIndexChanged);
            // 
            // btnDodajNovuVjezbu
            // 
            this.btnDodajNovuVjezbu.BackgroundImage = global::nova_aplikacija.Properties.Resources.Old_dumbbells_on_white;
            this.btnDodajNovuVjezbu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajNovuVjezbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnDodajNovuVjezbu.ForeColor = System.Drawing.Color.Red;
            this.btnDodajNovuVjezbu.Location = new System.Drawing.Point(578, 346);
            this.btnDodajNovuVjezbu.Name = "btnDodajNovuVjezbu";
            this.btnDodajNovuVjezbu.Size = new System.Drawing.Size(210, 92);
            this.btnDodajNovuVjezbu.TabIndex = 2;
            this.btnDodajNovuVjezbu.Text = "Dodaj novu vjezbu";
            this.btnDodajNovuVjezbu.UseVisualStyleBackColor = true;
            this.btnDodajNovuVjezbu.Click += new System.EventHandler(this.btnDodajNovuVjezbu_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nova_aplikacija.Properties.Resources.Old_dumbbells_on_white;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajNovuVjezbu);
            this.Controls.Add(this.gbVjezbe);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Shown += new System.EventHandler(this.Form3_Shown);
            this.gbVjezbe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVjezbe;
        private System.Windows.Forms.ListBox lsbListaVjezbi;
        private System.Windows.Forms.Button btnDodajNovuVjezbu;
    }
}