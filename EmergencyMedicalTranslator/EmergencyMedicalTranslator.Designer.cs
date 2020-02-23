namespace EmergencyMedicalTranslator
{
    partial class EmergencyMedicalTranslator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmergencyMedicalTranslator));
            this.btnRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecord.BackgroundImage")));
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(49, 23);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(203, 199);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // EmergencyMedicalTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 244);
            this.Controls.Add(this.btnRecord);
            this.Name = "EmergencyMedicalTranslator";
            this.Text = "Emergency Medical Translator";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRecord;
    }
}

