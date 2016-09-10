namespace DictionaryHash
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
            this.Add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.choose_btn = new System.Windows.Forms.Button();
            this.table_dataGridView = new System.Windows.Forms.DataGridView();
            this.keyColomn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColomn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_tb = new System.Windows.Forms.TextBox();
            this.key_tb = new System.Windows.Forms.TextBox();
            this.key_hint_lbl = new System.Windows.Forms.Label();
            this.value_hint_lbl = new System.Windows.Forms.Label();
            this.show_all_btn = new System.Windows.Forms.Button();
            this.test_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(285, 31);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 0;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(285, 64);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // choose_btn
            // 
            this.choose_btn.Location = new System.Drawing.Point(285, 93);
            this.choose_btn.Name = "choose_btn";
            this.choose_btn.Size = new System.Drawing.Size(75, 23);
            this.choose_btn.TabIndex = 4;
            this.choose_btn.Text = "Choose";
            this.choose_btn.UseVisualStyleBackColor = true;
            this.choose_btn.Click += new System.EventHandler(this.choose_btn_Click);
            // 
            // table_dataGridView
            // 
            this.table_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.table_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyColomn,
            this.valueColomn});
            this.table_dataGridView.Location = new System.Drawing.Point(12, 64);
            this.table_dataGridView.Name = "table_dataGridView";
            this.table_dataGridView.Size = new System.Drawing.Size(256, 252);
            this.table_dataGridView.TabIndex = 6;
            // 
            // keyColomn
            // 
            this.keyColomn.HeaderText = "key";
            this.keyColomn.Name = "keyColomn";
            this.keyColomn.ReadOnly = true;
            // 
            // valueColomn
            // 
            this.valueColomn.HeaderText = "value";
            this.valueColomn.Name = "valueColomn";
            this.valueColomn.ReadOnly = true;
            // 
            // value_tb
            // 
            this.value_tb.Location = new System.Drawing.Point(155, 33);
            this.value_tb.Name = "value_tb";
            this.value_tb.Size = new System.Drawing.Size(95, 20);
            this.value_tb.TabIndex = 7;
            // 
            // key_tb
            // 
            this.key_tb.Location = new System.Drawing.Point(55, 33);
            this.key_tb.Name = "key_tb";
            this.key_tb.Size = new System.Drawing.Size(94, 20);
            this.key_tb.TabIndex = 8;
            // 
            // key_hint_lbl
            // 
            this.key_hint_lbl.AutoSize = true;
            this.key_hint_lbl.Location = new System.Drawing.Point(95, 17);
            this.key_hint_lbl.Name = "key_hint_lbl";
            this.key_hint_lbl.Size = new System.Drawing.Size(24, 13);
            this.key_hint_lbl.TabIndex = 10;
            this.key_hint_lbl.Text = "key";
            // 
            // value_hint_lbl
            // 
            this.value_hint_lbl.AutoSize = true;
            this.value_hint_lbl.Location = new System.Drawing.Point(188, 17);
            this.value_hint_lbl.Name = "value_hint_lbl";
            this.value_hint_lbl.Size = new System.Drawing.Size(33, 13);
            this.value_hint_lbl.TabIndex = 11;
            this.value_hint_lbl.Text = "value";
            // 
            // show_all_btn
            // 
            this.show_all_btn.Location = new System.Drawing.Point(285, 122);
            this.show_all_btn.Name = "show_all_btn";
            this.show_all_btn.Size = new System.Drawing.Size(75, 23);
            this.show_all_btn.TabIndex = 12;
            this.show_all_btn.Text = "Show all";
            this.show_all_btn.UseVisualStyleBackColor = true;
            this.show_all_btn.Click += new System.EventHandler(this.show_all_btn_Click);
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(285, 151);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(75, 23);
            this.test_btn.TabIndex = 13;
            this.test_btn.Text = "Test";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 333);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.show_all_btn);
            this.Controls.Add(this.value_hint_lbl);
            this.Controls.Add(this.key_hint_lbl);
            this.Controls.Add(this.key_tb);
            this.Controls.Add(this.value_tb);
            this.Controls.Add(this.table_dataGridView);
            this.Controls.Add(this.choose_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Add_btn);
            this.Name = "MainForm";
            this.Text = "Dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.table_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button choose_btn;
        private System.Windows.Forms.DataGridView table_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyColomn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColomn;
        private System.Windows.Forms.TextBox value_tb;
        private System.Windows.Forms.TextBox key_tb;
        private System.Windows.Forms.Label key_hint_lbl;
        private System.Windows.Forms.Label value_hint_lbl;
        private System.Windows.Forms.Button show_all_btn;
        private System.Windows.Forms.Button test_btn;
    }
}

