namespace Q234787 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.myDateEdit1 = new DXSample.MyDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myDateEdit1
            // 
            this.myDateEdit1.EditValue = null;
            this.myDateEdit1.Location = new System.Drawing.Point(12, 12);
            this.myDateEdit1.Name = "myDateEdit1";
            this.myDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myDateEdit1.Properties.ShowWeekNumbers = true;
            this.myDateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.myDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.myDateEdit1.Size = new System.Drawing.Size(194, 20);
            this.myDateEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.myDateEdit1);
            this.Name = "Form1";
            this.Text = "DXSample";
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.MyDateEdit myDateEdit1;

    }
}

