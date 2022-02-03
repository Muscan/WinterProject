
namespace Session8
{
    partial class CrudSql
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReadAll = new System.Windows.Forms.Button();
            this.lstView = new System.Windows.Forms.ListView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxEngine = new System.Windows.Forms.TextBox();
            this.txtBoxSeriesYear = new System.Windows.Forms.TextBox();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.txtBoxDeleteCar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Controls.Add(this.btnReadAll, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCreate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxEngine, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxSeriesYear, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lstView, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteCar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxDeleteCar, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, -4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReadAll
            // 
            this.btnReadAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReadAll.Location = new System.Drawing.Point(3, 32);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(104, 52);
            this.btnReadAll.TabIndex = 0;
            this.btnReadAll.Text = "Read All Cars";
            this.btnReadAll.UseVisualStyleBackColor = true;
            this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
            // 
            // lstView
            // 
            this.lstView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstView.GridLines = true;
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(370, 119);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(408, 110);
            this.lstView.TabIndex = 1;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.lstViewDB_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Location = new System.Drawing.Point(3, 153);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 42);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Car";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(3, 235);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxName.TabIndex = 3;
            // 
            // txtBoxEngine
            // 
            this.txtBoxEngine.Location = new System.Drawing.Point(113, 235);
            this.txtBoxEngine.Name = "txtBoxEngine";
            this.txtBoxEngine.Size = new System.Drawing.Size(100, 22);
            this.txtBoxEngine.TabIndex = 4;
            // 
            // txtBoxSeriesYear
            // 
            this.txtBoxSeriesYear.Location = new System.Drawing.Point(223, 235);
            this.txtBoxSeriesYear.Name = "txtBoxSeriesYear";
            this.txtBoxSeriesYear.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSeriesYear.TabIndex = 5;
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(3, 284);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCar.TabIndex = 6;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // txtBoxDeleteCar
            // 
            this.txtBoxDeleteCar.Location = new System.Drawing.Point(113, 284);
            this.txtBoxDeleteCar.Name = "txtBoxDeleteCar";
            this.txtBoxDeleteCar.Size = new System.Drawing.Size(100, 22);
            this.txtBoxDeleteCar.TabIndex = 7;
            // 
            // CrudSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CrudSql";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnReadAll;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxEngine;
        private System.Windows.Forms.TextBox txtBoxSeriesYear;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.TextBox txtBoxDeleteCar;
    }
}

