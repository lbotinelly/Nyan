﻿namespace Nyan.Tools.LogMonitor
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.lstMain = new System.Windows.Forms.ListView();
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrMaintenance = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkIgGen = new System.Windows.Forms.CheckBox();
            this.btnAdjustColumns = new System.Windows.Forms.Button();
            this.chkAutoUpd = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMain
            // 
            this.lstMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMain.BackColor = System.Drawing.Color.Black;
            this.lstMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colType,
            this.colTS,
            this.colDescr});
            this.lstMain.Font = new System.Drawing.Font("ProFontWindows", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lstMain.ForeColor = System.Drawing.Color.Lime;
            this.lstMain.FullRowSelect = true;
            this.lstMain.Location = new System.Drawing.Point(0, 28);
            this.lstMain.Margin = new System.Windows.Forms.Padding(0);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(971, 360);
            this.lstMain.TabIndex = 0;
            this.lstMain.UseCompatibleStateImageBehavior = false;
            this.lstMain.View = System.Windows.Forms.View.Details;
            this.lstMain.SelectedIndexChanged += new System.EventHandler(this.lstMain_SelectedIndexChanged);
            // 
            // colType
            // 
            this.colType.Text = "Type";
            // 
            // colTS
            // 
            this.colTS.Text = "TimeStamp";
            // 
            // colDescr
            // 
            this.colDescr.Text = "Description";
            this.colDescr.Width = 193;
            // 
            // tmrMaintenance
            // 
            this.tmrMaintenance.Enabled = true;
            this.tmrMaintenance.Interval = 500;
            this.tmrMaintenance.Tick += new System.EventHandler(this.tmrMaintenance_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.chkIgGen);
            this.panel1.Controls.Add(this.btnAdjustColumns);
            this.panel1.Controls.Add(this.chkAutoUpd);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 29);
            this.panel1.TabIndex = 1;
            // 
            // chkIgGen
            // 
            this.chkIgGen.AutoSize = true;
            this.chkIgGen.Location = new System.Drawing.Point(248, 7);
            this.chkIgGen.Name = "chkIgGen";
            this.chkIgGen.Size = new System.Drawing.Size(97, 17);
            this.chkIgGen.TabIndex = 2;
            this.chkIgGen.Text = "Ignore Generic";
            this.chkIgGen.UseVisualStyleBackColor = true;
            this.chkIgGen.CheckedChanged += new System.EventHandler(this.chkIgGen_CheckedChanged);
            // 
            // btnAdjustColumns
            // 
            this.btnAdjustColumns.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdjustColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjustColumns.Location = new System.Drawing.Point(3, 3);
            this.btnAdjustColumns.Name = "btnAdjustColumns";
            this.btnAdjustColumns.Size = new System.Drawing.Size(120, 23);
            this.btnAdjustColumns.TabIndex = 1;
            this.btnAdjustColumns.Text = "Auto Adjust Columns";
            this.btnAdjustColumns.UseVisualStyleBackColor = false;
            this.btnAdjustColumns.Click += new System.EventHandler(this.btnAdjustColumns_Click);
            // 
            // chkAutoUpd
            // 
            this.chkAutoUpd.AutoSize = true;
            this.chkAutoUpd.Location = new System.Drawing.Point(155, 7);
            this.chkAutoUpd.Name = "chkAutoUpd";
            this.chkAutoUpd.Size = new System.Drawing.Size(87, 17);
            this.chkAutoUpd.TabIndex = 0;
            this.chkAutoUpd.Text = "Auto Update";
            this.chkAutoUpd.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Log Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstMain;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colTS;
        private System.Windows.Forms.ColumnHeader colDescr;
        private System.Windows.Forms.Timer tmrMaintenance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAutoUpd;
        private System.Windows.Forms.CheckBox chkIgGen;
        private System.Windows.Forms.Button btnAdjustColumns;
    }
}
