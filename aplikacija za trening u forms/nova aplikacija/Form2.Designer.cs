
namespace nova_aplikacija
{
    partial class Form2
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
            this.gbTrening = new System.Windows.Forms.GroupBox();
            this.lsbTrening = new System.Windows.Forms.ListBox();
            this.btnDodajVjezbu = new System.Windows.Forms.Button();
            this.btnZavrsiTrening = new System.Windows.Forms.Button();
            this.gbTrening.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTrening
            // 
            this.gbTrening.BackgroundImage = global::nova_aplikacija.Properties.Resources.Old_dumbbells_on_white;
            this.gbTrening.Controls.Add(this.lsbTrening);
            this.gbTrening.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gbTrening.ForeColor = System.Drawing.Color.Red;
            this.gbTrening.Location = new System.Drawing.Point(22, 23);
            this.gbTrening.Name = "gbTrening";
            this.gbTrening.Size = new System.Drawing.Size(435, 318);
            this.gbTrening.TabIndex = 0;
            this.gbTrening.TabStop = false;
            this.gbTrening.Text = "Trening";
            // 
            // lsbTrening
            // 
            this.lsbTrening.BackColor = System.Drawing.Color.Snow;
            this.lsbTrening.ForeColor = System.Drawing.Color.Red;
            this.lsbTrening.FormattingEnabled = true;
            this.lsbTrening.ItemHeight = 25;
            this.lsbTrening.Location = new System.Drawing.Point(18, 29);
            this.lsbTrening.Name = "lsbTrening";
            this.lsbTrening.Size = new System.Drawing.Size(379, 254);
            this.lsbTrening.TabIndex = 0;
            this.lsbTrening.SelectedIndexChanged += new System.EventHandler(this.lsbTrening_SelectedIndexChanged);
            // 
            // btnDodajVjezbu
            // 
            this.btnDodajVjezbu.BackgroundImage = global::nova_aplikacija.Properties.Resources.Old_dumbbells_on_white;
            this.btnDodajVjezbu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajVjezbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnDodajVjezbu.ForeColor = System.Drawing.Color.Red;
            this.btnDodajVjezbu.Location = new System.Drawing.Point(549, 372);
            this.btnDodajVjezbu.Name = "btnDodajVjezbu";
            this.btnDodajVjezbu.Size = new System.Drawing.Size(210, 56);
            this.btnDodajVjezbu.TabIndex = 1;
            this.btnDodajVjezbu.Text = "Dodaj vjezbu";
            this.btnDodajVjezbu.UseVisualStyleBackColor = true;
            this.btnDodajVjezbu.Click += new System.EventHandler(this.btnDodajVjezbu_Click);
            // 
            // btnZavrsiTrening
            // 
            this.btnZavrsiTrening.Location = new System.Drawing.Point(115, 362);
            this.btnZavrsiTrening.Name = "btnZavrsiTrening";
            this.btnZavrsiTrening.Size = new System.Drawing.Size(186, 66);
            this.btnZavrsiTrening.TabIndex = 2;
            this.btnZavrsiTrening.Text = "Zavrsi Trening";
            this.btnZavrsiTrening.UseVisualStyleBackColor = true;
            this.btnZavrsiTrening.Click += new System.EventHandler(this.btnZavrsiTrening_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nova_aplikacija.Properties.Resources.Old_dumbbells_on_white;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZavrsiTrening);
            this.Controls.Add(this.btnDodajVjezbu);
            this.Controls.Add(this.gbTrening);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbTrening.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTrening;
        public System.Windows.Forms.ListBox lsbTrening;
        private System.Windows.Forms.Button btnDodajVjezbu;
        private System.Windows.Forms.Button btnZavrsiTrening;
    }
}