namespace Proejkt_BD.Control.Menager
{
    partial class Customers
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.addButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rSSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rSSDataSet = new Proejkt_BD.RSSDataSet();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONELTableAdapter = new Proejkt_BD.RSSDataSetTableAdapters.PERSONELTableAdapter();
            this.cLIENTTableAdapter = new Proejkt_BD.RSSDataSetTableAdapters.CLIENTTableAdapter();
            this.cLIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(294, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 54);
            this.button1.TabIndex = 25;
            this.button1.Text = "Edit Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton1
            // 
            this.addButton1.BackColor = System.Drawing.Color.White;
            this.addButton1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton1.Location = new System.Drawing.Point(6, 335);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(282, 54);
            this.addButton1.TabIndex = 24;
            this.addButton1.Text = "Add Customer";
            this.addButton1.UseVisualStyleBackColor = false;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(197, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // fnameBox
            // 
            this.fnameBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fnameBox.Location = new System.Drawing.Point(314, 13);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(100, 21);
            this.fnameBox.TabIndex = 19;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameBox.Location = new System.Drawing.Point(91, 11);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 21);
            this.nameBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(423, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(544, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 30;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(568, 335);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 54);
            this.button5.TabIndex = 31;
            this.button5.Text = "Show Customer Details";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 281);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "id_client";
            this.idclientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTBindingSource2
            // 
            this.cLIENTBindingSource2.DataMember = "CLIENT";
            this.cLIENTBindingSource2.DataSource = this.rSSDataSetBindingSource;
            // 
            // rSSDataSetBindingSource
            // 
            this.rSSDataSetBindingSource.DataSource = this.rSSDataSet;
            this.rSSDataSetBindingSource.Position = 0;
            this.rSSDataSetBindingSource.CurrentChanged += new System.EventHandler(this.rSSDataSetBindingSource_CurrentChanged);
            // 
            // rSSDataSet
            // 
            this.rSSDataSet.DataSetName = "RSSDataSet";
            this.rSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.rSSDataSetBindingSource;
            // 
            // pERSONELBindingSource
            // 
            this.pERSONELBindingSource.DataMember = "PERSONEL";
            this.pERSONELBindingSource.DataSource = this.rSSDataSetBindingSource;
            // 
            // pERSONELTableAdapter
            // 
            this.pERSONELTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTBindingSource1
            // 
            this.cLIENTBindingSource1.DataMember = "CLIENT";
            this.cLIENTBindingSource1.DataSource = this.rSSDataSetBindingSource;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBox.Location = new System.Drawing.Point(700, 9);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(75, 23);
            this.searchBox.TabIndex = 22;
            this.searchBox.Text = "Search";
            this.searchBox.UseVisualStyleBackColor = false;
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.nameBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(802, 392);
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Button searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rSSDataSetBindingSource;
        private RSSDataSet rSSDataSet;
        private System.Windows.Forms.BindingSource pERSONELBindingSource;
        private RSSDataSetTableAdapters.PERSONELTableAdapter pERSONELTableAdapter;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private RSSDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cLIENTBindingSource2;
        private System.Windows.Forms.BindingSource cLIENTBindingSource1;
    }
}
