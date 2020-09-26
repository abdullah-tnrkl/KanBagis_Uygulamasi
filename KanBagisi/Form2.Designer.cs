namespace KanBagisi
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
            this.dataGridViewListe = new System.Windows.Forms.DataGridView();
            this.buttonDetayGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListe
            // 
            this.dataGridViewListe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListe.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewListe.Name = "dataGridViewListe";
            this.dataGridViewListe.Size = new System.Drawing.Size(734, 331);
            this.dataGridViewListe.TabIndex = 0;
            // 
            // buttonDetayGoster
            // 
            this.buttonDetayGoster.Location = new System.Drawing.Point(635, 13);
            this.buttonDetayGoster.Name = "buttonDetayGoster";
            this.buttonDetayGoster.Size = new System.Drawing.Size(111, 23);
            this.buttonDetayGoster.TabIndex = 1;
            this.buttonDetayGoster.Text = "Kaydet";
            this.buttonDetayGoster.UseVisualStyleBackColor = true;
            this.buttonDetayGoster.Click += new System.EventHandler(this.buttonDetayGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BAĞIŞ LİSTESİ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDetayGoster);
            this.Controls.Add(this.dataGridViewListe);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListe;
        private System.Windows.Forms.Button buttonDetayGoster;
        private System.Windows.Forms.Label label1;
    }
}