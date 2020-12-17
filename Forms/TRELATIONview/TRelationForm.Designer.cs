namespace TestWinApp.Forms
{
    partial class TRelationForm
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
            this.relationDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.relationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relationDataGridView
            // 
            this.relationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.relationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relationDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.relationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.relationDataGridView.Name = "relationDataGridView";
            this.relationDataGridView.Size = new System.Drawing.Size(799, 294);
            this.relationDataGridView.TabIndex = 1;
            this.relationDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.relationDataGridView_CellEndEdit);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(80, 355);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 40);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add ";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(322, 355);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(150, 40);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(564, 355);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(150, 40);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // TRelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.relationDataGridView);
            this.Name = "TRelationForm";
            this.Text = "TRelationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TRelationForm_FormClosing);
            this.Load += new System.EventHandler(this.TRelationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView relationDataGridView;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Delete;
    }
}