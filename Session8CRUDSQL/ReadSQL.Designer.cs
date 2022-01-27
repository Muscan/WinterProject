namespace Session8CRUDSQL
{
    partial class ReadSQL
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
            this.btnRead = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReadAdoNet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(477, 372);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(118, 29);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read Entity";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(685, 255);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnReadAdoNet
            // 
            this.btnReadAdoNet.Location = new System.Drawing.Point(157, 372);
            this.btnReadAdoNet.Name = "btnReadAdoNet";
            this.btnReadAdoNet.Size = new System.Drawing.Size(178, 29);
            this.btnReadAdoNet.TabIndex = 2;
            this.btnReadAdoNet.Text = "Read AdoNet";
            this.btnReadAdoNet.UseVisualStyleBackColor = true;
            this.btnReadAdoNet.Click += new System.EventHandler(this.btnReadAdoNet_Click);
            // 
            // ReadSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadAdoNet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRead);
            this.Name = "ReadSQL";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRead;
        private DataGridView dataGridView1;
        private Button btnReadAdoNet;
    }
}