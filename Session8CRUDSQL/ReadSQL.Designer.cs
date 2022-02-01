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
            this.components = new System.ComponentModel.Container();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnReadAdoNet = new System.Windows.Forms.Button();
            this.carRentalContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(477, 372);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(128, 29);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read Entity";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
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
            // lstView
            // 
            this.lstView.GridLines = true;
            this.lstView.Location = new System.Drawing.Point(93, 84);
            this.lstView.Name = "lstView";
            this.lstView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstView.Size = new System.Drawing.Size(589, 139);
            this.lstView.TabIndex = 3;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.lstView_SelectedIndexChanged);
            // 
            // ReadSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.btnReadAdoNet);
            this.Controls.Add(this.btnRead);
            this.Name = "ReadSQL";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carRentalContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRead;
        private Button btnReadAdoNet;
        private BindingSource carRentalContextBindingSource;
        private BindingSource carBindingSource;
        private ListView lstView;
    }
}