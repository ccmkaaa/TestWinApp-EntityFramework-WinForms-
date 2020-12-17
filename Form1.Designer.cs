namespace TestWinApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_TGroup = new System.Windows.Forms.Button();
            this.btn_TRelation = new System.Windows.Forms.Button();
            this.btn_TProperty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(805, 64);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_TGroup
            // 
            this.btn_TGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_TGroup.Location = new System.Drawing.Point(59, 439);
            this.btn_TGroup.Name = "btn_TGroup";
            this.btn_TGroup.Size = new System.Drawing.Size(184, 71);
            this.btn_TGroup.TabIndex = 1;
            this.btn_TGroup.Text = "Show TGROUP";
            this.btn_TGroup.UseVisualStyleBackColor = true;
            this.btn_TGroup.Click += new System.EventHandler(this.btn_TGroup_Click);
            // 
            // btn_TRelation
            // 
            this.btn_TRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_TRelation.Location = new System.Drawing.Point(317, 439);
            this.btn_TRelation.Name = "btn_TRelation";
            this.btn_TRelation.Size = new System.Drawing.Size(184, 71);
            this.btn_TRelation.TabIndex = 2;
            this.btn_TRelation.Text = "Show TRELATION";
            this.btn_TRelation.UseVisualStyleBackColor = true;
            this.btn_TRelation.Click += new System.EventHandler(this.btn_TRelation_Click);
            // 
            // btn_TProperty
            // 
            this.btn_TProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_TProperty.Location = new System.Drawing.Point(569, 439);
            this.btn_TProperty.Name = "btn_TProperty";
            this.btn_TProperty.Size = new System.Drawing.Size(184, 71);
            this.btn_TProperty.TabIndex = 3;
            this.btn_TProperty.Text = "Show TPROPERTY";
            this.btn_TProperty.UseVisualStyleBackColor = true;
            this.btn_TProperty.Click += new System.EventHandler(this.btn_TProperty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 619);
            this.Controls.Add(this.btn_TProperty);
            this.Controls.Add(this.btn_TRelation);
            this.Controls.Add(this.btn_TGroup);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_TGroup;
        private System.Windows.Forms.Button btn_TRelation;
        private System.Windows.Forms.Button btn_TProperty;
    }
}

