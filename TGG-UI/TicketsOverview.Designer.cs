﻿
namespace TGG_UI
{
    partial class TicketsOverview
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
            this.gridViewTickets = new System.Windows.Forms.DataGridView();
            this.buttonAddTicketsForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewTickets
            // 
            this.gridViewTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTickets.GridColor = System.Drawing.Color.Black;
            this.gridViewTickets.Location = new System.Drawing.Point(70, 160);
            this.gridViewTickets.Name = "gridViewTickets";
            this.gridViewTickets.Size = new System.Drawing.Size(744, 690);
            this.gridViewTickets.TabIndex = 0;
            // 
            // buttonAddTicketsForm
            // 
            this.buttonAddTicketsForm.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddTicketsForm.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTicketsForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddTicketsForm.Location = new System.Drawing.Point(549, 79);
            this.buttonAddTicketsForm.Name = "buttonAddTicketsForm";
            this.buttonAddTicketsForm.Size = new System.Drawing.Size(266, 54);
            this.buttonAddTicketsForm.TabIndex = 1;
            this.buttonAddTicketsForm.Text = "Add Tickets";
            this.buttonAddTicketsForm.UseVisualStyleBackColor = false;
            this.buttonAddTicketsForm.Click += new System.EventHandler(this.buttonAddTicketsForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Overview Tickets";
            // 
            // TicketsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(884, 951);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddTicketsForm);
            this.Controls.Add(this.gridViewTickets);
            this.Name = "TicketsOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewTickets;
        private System.Windows.Forms.Button buttonAddTicketsForm;
        private System.Windows.Forms.Label label1;
    }
}