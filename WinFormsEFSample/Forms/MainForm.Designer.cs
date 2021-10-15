
namespace WinFormsEFSample.Forms
{
    partial class MainForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvHerbs = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.HerbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HerbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerbs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(658, 442);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvHerbs
            // 
            this.dgvHerbs.AllowUserToAddRows = false;
            this.dgvHerbs.AllowUserToDeleteRows = false;
            this.dgvHerbs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHerbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHerbs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HerbId,
            this.HerbName});
            this.dgvHerbs.Location = new System.Drawing.Point(12, 12);
            this.dgvHerbs.Name = "dgvHerbs";
            this.dgvHerbs.ReadOnly = true;
            this.dgvHerbs.RowHeadersVisible = false;
            this.dgvHerbs.RowHeadersWidth = 51;
            this.dgvHerbs.RowTemplate.Height = 29;
            this.dgvHerbs.Size = new System.Drawing.Size(740, 424);
            this.dgvHerbs.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 446);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(36, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "N/A";
            // 
            // HerbId
            // 
            this.HerbId.DataPropertyName = "Id";
            this.HerbId.HeaderText = "Id";
            this.HerbId.MinimumWidth = 6;
            this.HerbId.Name = "HerbId";
            this.HerbId.ReadOnly = true;
            this.HerbId.Width = 300;
            // 
            // HerbName
            // 
            this.HerbName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HerbName.DataPropertyName = "Name";
            this.HerbName.HeaderText = "Name";
            this.HerbName.MinimumWidth = 6;
            this.HerbName.Name = "HerbName";
            this.HerbName.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 483);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvHerbs);
            this.Controls.Add(this.btnRefresh);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerbs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvHerbs;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn HerbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HerbName;
    }
}