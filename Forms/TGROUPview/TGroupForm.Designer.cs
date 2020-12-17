namespace TestWinApp.Forms
{
    partial class TGroupForm
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
            this.groupDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDataGridView
            // 
            this.groupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDataGridView.Location = new System.Drawing.Point(0, 0);
            this.groupDataGridView.Name = "groupDataGridView";
            this.groupDataGridView.Size = new System.Drawing.Size(799, 294);
            this.groupDataGridView.TabIndex = 0;
            this.groupDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupDataGridView_CellEndEdit);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(71, 340);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 40);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add ";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(531, 340);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(150, 40);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(304, 340);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(150, 40);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // TGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupDataGridView);
            this.Name = "TGroupForm";
            this.Text = "TGroupForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TGroupForm_FormClosing);
            this.Load += new System.EventHandler(this.TGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
        internal System.Windows.Forms.DataGridView groupDataGridView;
    }
}