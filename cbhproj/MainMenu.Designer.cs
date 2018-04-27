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
            this.btnSearchBySSN = new System.Windows.Forms.Button();
            this.btnSearchByOLN = new System.Windows.Forms.Button();
            this.btnAddModify = new System.Windows.Forms.Button();
            this.btnDeleteBySSN = new System.Windows.Forms.Button();
            this.btnListMaster = new System.Windows.Forms.Button();
            this.btnDeleteByOLN = new System.Windows.Forms.Button();
            this.btnInitialDataLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(269, 42);
            this.lblMainMenu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(487, 79);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Police Information System";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(399, 692);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 58);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAuxFiles
            // 
            this.btnAuxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuxFiles.Location = new System.Drawing.Point(269, 188);
            this.btnAuxFiles.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAuxFiles.Name = "btnAuxFiles";
            this.btnAuxFiles.Size = new System.Drawing.Size(487, 64);
            this.btnAuxFiles.TabIndex = 2;
            this.btnAuxFiles.Text = "Display Auxiliary Files";
            this.btnAuxFiles.UseVisualStyleBackColor = true;
            this.btnAuxFiles.Click += new System.EventHandler(this.btnAuxFIles_Click);
            // 
            // btnSearchBySSN
            // 
            this.btnSearchBySSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBySSN.Location = new System.Drawing.Point(269, 260);
            this.btnSearchBySSN.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSearchBySSN.Name = "btnSearchBySSN";
            this.btnSearchBySSN.Size = new System.Drawing.Size(487, 64);
            this.btnSearchBySSN.TabIndex = 3;
            this.btnSearchBySSN.Text = "Display a Record (by SSN)";
            this.btnSearchBySSN.UseVisualStyleBackColor = true;
            this.btnSearchBySSN.Click += new System.EventHandler(this.btnSearchBySSN_Click);
            // 
            // btnSearchByOLN
            // 
            this.btnSearchByOLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByOLN.Location = new System.Drawing.Point(269, 332);
            this.btnSearchByOLN.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSearchByOLN.Name = "btnSearchByOLN";
            this.btnSearchByOLN.Size = new System.Drawing.Size(487, 64);
            this.btnSearchByOLN.TabIndex = 4;
            this.btnSearchByOLN.Text = "Display a Record (by OLN)";
            this.btnSearchByOLN.UseVisualStyleBackColor = true;
            this.btnSearchByOLN.Click += new System.EventHandler(this.btnSearchByOLN_Click);
            // 
            // btnAddModify
            // 
            this.btnAddModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModify.Location = new System.Drawing.Point(269, 548);
            this.btnAddModify.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAddModify.Name = "btnAddModify";
            this.btnAddModify.Size = new System.Drawing.Size(487, 64);
            this.btnAddModify.TabIndex = 5;
            this.btnAddModify.Text = "Add/Update a Record";
            this.btnAddModify.UseVisualStyleBackColor = true;
            this.btnAddModify.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnDeleteBySSN
            // 
            this.btnDeleteBySSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBySSN.Location = new System.Drawing.Point(269, 404);
            this.btnDeleteBySSN.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDeleteBySSN.Name = "btnDeleteBySSN";
            this.btnDeleteBySSN.Size = new System.Drawing.Size(487, 64);
            this.btnDeleteBySSN.TabIndex = 6;
            this.btnDeleteBySSN.Text = "Delete a Record (by SSN)";
            this.btnDeleteBySSN.UseVisualStyleBackColor = true;
            this.btnDeleteBySSN.Click += new System.EventHandler(this.btnDeleteBySSN_Click);
            // 
            // btnListMaster
            // 
            this.btnListMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMaster.Location = new System.Drawing.Point(269, 620);
            this.btnListMaster.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnListMaster.Name = "btnListMaster";
            this.btnListMaster.Size = new System.Drawing.Size(487, 64);
            this.btnListMaster.TabIndex = 8;
            this.btnListMaster.Text = "List Master File";
            this.btnListMaster.UseVisualStyleBackColor = true;
            // 
            // btnDeleteByOLN
            // 
            this.btnDeleteByOLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteByOLN.Location = new System.Drawing.Point(269, 476);
            this.btnDeleteByOLN.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDeleteByOLN.Name = "btnDeleteByOLN";
            this.btnDeleteByOLN.Size = new System.Drawing.Size(487, 64);
            this.btnDeleteByOLN.TabIndex = 9;
            this.btnDeleteByOLN.Text = "Delete a Record (by OLN)";
            this.btnDeleteByOLN.UseVisualStyleBackColor = true;
            this.btnDeleteByOLN.Click += new System.EventHandler(this.btnDeleteByOLN_Click);
            // 
            // btnInitialDataLoad
            // 
            this.btnInitialDataLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitialDataLoad.Location = new System.Drawing.Point(269, 116);
            this.btnInitialDataLoad.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnInitialDataLoad.Name = "btnInitialDataLoad";
            this.btnInitialDataLoad.Size = new System.Drawing.Size(487, 64);
            this.btnInitialDataLoad.TabIndex = 10;
            this.btnInitialDataLoad.Text = "Initial Data Load";
            this.btnInitialDataLoad.UseVisualStyleBackColor = true;
            this.btnInitialDataLoad.Click += new System.EventHandler(this.btnInitialDataLoad_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.btnInitialDataLoad);
            this.Controls.Add(this.btnDeleteByOLN);
            this.Controls.Add(this.btnListMaster);
            this.Controls.Add(this.btnDeleteBySSN);
            this.Controls.Add(this.btnAddModify);
            this.Controls.Add(this.btnSearchByOLN);
            this.Controls.Add(this.btnSearchBySSN);
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
        private System.Windows.Forms.Button btnSearchBySSN;
        private System.Windows.Forms.Button btnSearchByOLN;
        private System.Windows.Forms.Button btnAddModify;
        private System.Windows.Forms.Button btnDeleteBySSN;
        private System.Windows.Forms.Button btnListMaster;
        private System.Windows.Forms.Button btnDeleteByOLN;
        private System.Windows.Forms.Button btnInitialDataLoad;
    }
}

