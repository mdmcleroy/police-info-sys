namespace cbhproj
{
    partial class MainMenu
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
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAuxFiles = new System.Windows.Forms.Button();
            this.btnSSNMenu = new System.Windows.Forms.Button();
            this.btnOLNMenu = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnModifyRecord = new System.Windows.Forms.Button();
            this.btnListMaster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(79, 40);
            this.lblMainMenu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(857, 79);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Police Information System";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(394, 643);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 58);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAuxFiles
            // 
            this.btnAuxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuxFiles.Location = new System.Drawing.Point(264, 134);
            this.btnAuxFiles.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAuxFiles.Name = "btnAuxFiles";
            this.btnAuxFiles.Size = new System.Drawing.Size(487, 64);
            this.btnAuxFiles.TabIndex = 2;
            this.btnAuxFiles.Text = "Display Auxiliary Files";
            this.btnAuxFiles.UseVisualStyleBackColor = true;
            this.btnAuxFiles.Click += new System.EventHandler(this.btnAuxFIles_Click);
            // 
            // btnSSNMenu
            // 
            this.btnSSNMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSNMenu.Location = new System.Drawing.Point(264, 206);
            this.btnSSNMenu.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSSNMenu.Name = "btnSSNMenu";
            this.btnSSNMenu.Size = new System.Drawing.Size(487, 64);
            this.btnSSNMenu.TabIndex = 3;
            this.btnSSNMenu.Text = "Display a Record (by SSN)";
            this.btnSSNMenu.UseVisualStyleBackColor = true;
            this.btnSSNMenu.Click += new System.EventHandler(this.btnSSNMenu_Click);
            // 
            // btnOLNMenu
            // 
            this.btnOLNMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOLNMenu.Location = new System.Drawing.Point(264, 278);
            this.btnOLNMenu.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnOLNMenu.Name = "btnOLNMenu";
            this.btnOLNMenu.Size = new System.Drawing.Size(487, 64);
            this.btnOLNMenu.TabIndex = 4;
            this.btnOLNMenu.Text = "Display a Record (by OLN)";
            this.btnOLNMenu.UseVisualStyleBackColor = true;
            this.btnOLNMenu.Click += new System.EventHandler(this.btnOLNMenu_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Location = new System.Drawing.Point(264, 350);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(487, 64);
            this.btnAddRecord.TabIndex = 5;
            this.btnAddRecord.Text = "Add a Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.Location = new System.Drawing.Point(264, 422);
            this.btnDeleteRecord.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(487, 64);
            this.btnDeleteRecord.TabIndex = 6;
            this.btnDeleteRecord.Text = "Delete a Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnModifyRecord
            // 
            this.btnModifyRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyRecord.Location = new System.Drawing.Point(264, 494);
            this.btnModifyRecord.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnModifyRecord.Name = "btnModifyRecord";
            this.btnModifyRecord.Size = new System.Drawing.Size(487, 64);
            this.btnModifyRecord.TabIndex = 7;
            this.btnModifyRecord.Text = "Modify a Record";
            this.btnModifyRecord.UseVisualStyleBackColor = true;
            this.btnModifyRecord.Click += new System.EventHandler(this.btnModifyRecord_Click);
            // 
            // btnListMaster
            // 
            this.btnListMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMaster.Location = new System.Drawing.Point(264, 566);
            this.btnListMaster.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnListMaster.Name = "btnListMaster";
            this.btnListMaster.Size = new System.Drawing.Size(487, 64);
            this.btnListMaster.TabIndex = 8;
            this.btnListMaster.Text = "List Master File";
            this.btnListMaster.UseVisualStyleBackColor = true;
            this.btnListMaster.Click += new System.EventHandler(this.btnListMaster_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1015, 749);
            this.Controls.Add(this.btnListMaster);
            this.Controls.Add(this.btnModifyRecord);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.btnOLNMenu);
            this.Controls.Add(this.btnSSNMenu);
            this.Controls.Add(this.btnAuxFiles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cbhproj";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAuxFiles;
        private System.Windows.Forms.Button btnSSNMenu;
        private System.Windows.Forms.Button btnOLNMenu;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnModifyRecord;
        private System.Windows.Forms.Button btnListMaster;
    }
}

