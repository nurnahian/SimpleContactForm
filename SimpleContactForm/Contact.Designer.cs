
namespace SimpleContactForm
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxCustomarId = new System.Windows.Forms.TextBox();
            this.txtboxFname = new System.Windows.Forms.TextBox();
            this.labFname = new System.Windows.Forms.Label();
            this.txtboxContactNo = new System.Windows.Forms.TextBox();
            this.labContactNo = new System.Windows.Forms.Label();
            this.txtboxLname = new System.Windows.Forms.TextBox();
            this.labLname = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.labAddress = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ContactdataGridView = new System.Windows.Forms.DataGridView();
            this.labSearch = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customar ID";
            // 
            // txtboxCustomarId
            // 
            this.txtboxCustomarId.Location = new System.Drawing.Point(172, 116);
            this.txtboxCustomarId.Name = "txtboxCustomarId";
            this.txtboxCustomarId.ReadOnly = true;
            this.txtboxCustomarId.Size = new System.Drawing.Size(205, 26);
            this.txtboxCustomarId.TabIndex = 2;
            // 
            // txtboxFname
            // 
            this.txtboxFname.Location = new System.Drawing.Point(172, 163);
            this.txtboxFname.Name = "txtboxFname";
            this.txtboxFname.Size = new System.Drawing.Size(205, 26);
            this.txtboxFname.TabIndex = 4;
            // 
            // labFname
            // 
            this.labFname.AutoSize = true;
            this.labFname.Location = new System.Drawing.Point(12, 163);
            this.labFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFname.Name = "labFname";
            this.labFname.Size = new System.Drawing.Size(87, 20);
            this.labFname.TabIndex = 3;
            this.labFname.Text = "Fast Name";
            // 
            // txtboxContactNo
            // 
            this.txtboxContactNo.Location = new System.Drawing.Point(172, 255);
            this.txtboxContactNo.Name = "txtboxContactNo";
            this.txtboxContactNo.Size = new System.Drawing.Size(205, 26);
            this.txtboxContactNo.TabIndex = 8;
            // 
            // labContactNo
            // 
            this.labContactNo.AutoSize = true;
            this.labContactNo.Location = new System.Drawing.Point(12, 255);
            this.labContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labContactNo.Name = "labContactNo";
            this.labContactNo.Size = new System.Drawing.Size(89, 20);
            this.labContactNo.TabIndex = 7;
            this.labContactNo.Text = "Contact No";
            // 
            // txtboxLname
            // 
            this.txtboxLname.Location = new System.Drawing.Point(172, 208);
            this.txtboxLname.Name = "txtboxLname";
            this.txtboxLname.Size = new System.Drawing.Size(205, 26);
            this.txtboxLname.TabIndex = 6;
            // 
            // labLname
            // 
            this.labLname.AutoSize = true;
            this.labLname.Location = new System.Drawing.Point(12, 208);
            this.labLname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLname.Name = "labLname";
            this.labLname.Size = new System.Drawing.Size(86, 20);
            this.labLname.TabIndex = 5;
            this.labLname.Text = "Last Name";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(12, 419);
            this.labGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(63, 20);
            this.labGender.TabIndex = 11;
            this.labGender.Text = "Gender";
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(172, 304);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(205, 88);
            this.txtboxAddress.TabIndex = 10;
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(12, 304);
            this.labAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(68, 20);
            this.labAddress.TabIndex = 9;
            this.labAddress.Text = "Address";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(297, 475);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 34);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(408, 475);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 34);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(629, 475);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 34);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(518, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ContactdataGridView
            // 
            this.ContactdataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.ContactdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactdataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContactdataGridView.Location = new System.Drawing.Point(394, 163);
            this.ContactdataGridView.Name = "ContactdataGridView";
            this.ContactdataGridView.Size = new System.Drawing.Size(680, 282);
            this.ContactdataGridView.TabIndex = 17;
            this.ContactdataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ContactdataGridView_RowHeaderMouseClick);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(390, 115);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(60, 20);
            this.labSearch.TabIndex = 18;
            this.labSearch.Text = "Search";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(449, 114);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(625, 26);
            this.txtboxSearch.TabIndex = 19;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(172, 416);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 28);
            this.comboBox1.TabIndex = 20;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(994, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 34);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 531);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.ContactdataGridView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.txtboxContactNo);
            this.Controls.Add(this.labContactNo);
            this.Controls.Add(this.txtboxLname);
            this.Controls.Add(this.labLname);
            this.Controls.Add(this.txtboxFname);
            this.Controls.Add(this.labFname);
            this.Controls.Add(this.txtboxCustomarId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Contact";
            this.Text = "Contact Form";
            this.Load += new System.EventHandler(this.Contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxCustomarId;
        private System.Windows.Forms.TextBox txtboxFname;
        private System.Windows.Forms.Label labFname;
        private System.Windows.Forms.TextBox txtboxContactNo;
        private System.Windows.Forms.Label labContactNo;
        private System.Windows.Forms.TextBox txtboxLname;
        private System.Windows.Forms.Label labLname;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView ContactdataGridView;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnExit;
    }
}

