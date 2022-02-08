
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workersDataSet = new WindowsFormsApp1.WorkersDataSet();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new WindowsFormsApp1.WorkersDataSetTableAdapters.WorkerTableAdapter();
            this.widDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wpositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.widDataGridViewTextBoxColumn,
            this.wnameDataGridViewTextBoxColumn,
            this.wpositionDataGridViewTextBoxColumn,
            this.wsalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // workersDataSet
            // 
            this.workersDataSet.DataSetName = "WorkersDataSet";
            this.workersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.workersDataSet;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // widDataGridViewTextBoxColumn
            // 
            this.widDataGridViewTextBoxColumn.DataPropertyName = "w_id";
            this.widDataGridViewTextBoxColumn.HeaderText = "w_id";
            this.widDataGridViewTextBoxColumn.Name = "widDataGridViewTextBoxColumn";
            // 
            // wnameDataGridViewTextBoxColumn
            // 
            this.wnameDataGridViewTextBoxColumn.DataPropertyName = "w_name";
            this.wnameDataGridViewTextBoxColumn.HeaderText = "w_name";
            this.wnameDataGridViewTextBoxColumn.Name = "wnameDataGridViewTextBoxColumn";
            // 
            // wpositionDataGridViewTextBoxColumn
            // 
            this.wpositionDataGridViewTextBoxColumn.DataPropertyName = "w_position";
            this.wpositionDataGridViewTextBoxColumn.HeaderText = "w_position";
            this.wpositionDataGridViewTextBoxColumn.Name = "wpositionDataGridViewTextBoxColumn";
            // 
            // wsalaryDataGridViewTextBoxColumn
            // 
            this.wsalaryDataGridViewTextBoxColumn.DataPropertyName = "w_salary";
            this.wsalaryDataGridViewTextBoxColumn.HeaderText = "w_salary";
            this.wsalaryDataGridViewTextBoxColumn.Name = "wsalaryDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WorkersDataSet workersDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private WorkersDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn widDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wpositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wsalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

