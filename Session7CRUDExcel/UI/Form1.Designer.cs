namespace Session7CRUDExcel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtaGridView = new System.Windows.Forms.DataGridView();
            this.btnCreateExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridView
            // 
            this.dtaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridView.Location = new System.Drawing.Point(84, 25);
            this.dtaGridView.Name = "dtaGridView";
            this.dtaGridView.RowHeadersWidth = 51;
            this.dtaGridView.RowTemplate.Height = 29;
            this.dtaGridView.Size = new System.Drawing.Size(490, 202);
            this.dtaGridView.TabIndex = 0;
            // 
            // btnCreateExcel
            // 
            this.btnCreateExcel.Location = new System.Drawing.Point(354, 352);
            this.btnCreateExcel.Name = "btnCreateExcel";
            this.btnCreateExcel.Size = new System.Drawing.Size(94, 29);
            this.btnCreateExcel.TabIndex = 1;
            this.btnCreateExcel.Text = "Create Excel";
            this.btnCreateExcel.UseVisualStyleBackColor = true;
            this.btnCreateExcel.Click += new System.EventHandler(this.btnCreateExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateExcel);
            this.Controls.Add(this.dtaGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtaGridView;
        private Button btnCreateExcel;
    }
}