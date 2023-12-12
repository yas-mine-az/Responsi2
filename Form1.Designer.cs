namespace Responsi2
{
    partial class Form1
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
            this.labelLogo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.dropdownDep = new System.Windows.Forms.ComboBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.IDdept = new System.Windows.Forms.GroupBox();
            this.karyawan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawan)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Location = new System.Drawing.Point(71, 29);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(27, 13);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "logo";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(16, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(49, 50);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(12, 87);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(91, 13);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Nama Karyawan :";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(12, 116);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(89, 13);
            this.labelDep.TabIndex = 3;
            this.labelDep.Text = "Dep. Karyawan : ";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(109, 84);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(100, 20);
            this.tbNama.TabIndex = 4;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // dropdownDep
            // 
            this.dropdownDep.FormattingEnabled = true;
            this.dropdownDep.Location = new System.Drawing.Point(109, 113);
            this.dropdownDep.Name = "dropdownDep";
            this.dropdownDep.Size = new System.Drawing.Size(121, 21);
            this.dropdownDep.TabIndex = 5;
            this.dropdownDep.SelectedIndexChanged += new System.EventHandler(this.dropdownDep_SelectedIndexChanged);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(16, 155);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(183, 155);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(350, 155);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // IDdept
            // 
            this.IDdept.Location = new System.Drawing.Point(263, 12);
            this.IDdept.Name = "IDdept";
            this.IDdept.Size = new System.Drawing.Size(153, 122);
            this.IDdept.TabIndex = 9;
            this.IDdept.TabStop = false;
            this.IDdept.Text = "ID Departemen";
            // 
            // karyawan
            // 
            this.karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.karyawan.Location = new System.Drawing.Point(16, 199);
            this.karyawan.Name = "karyawan";
            this.karyawan.Size = new System.Drawing.Size(401, 150);
            this.karyawan.TabIndex = 10;
            this.karyawan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabeldata_CellContentClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(436, 371);
            this.Controls.Add(this.karyawan);
            this.Controls.Add(this.IDdept);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dropdownDep);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.labelLogo);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.ComboBox dropdownDep;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox IDdept;
        private System.Windows.Forms.DataGridView karyawan;
    }
}

