namespace SDN.Programs
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
            this.lsvImages = new System.Windows.Forms.ListView();
            this.btnMove = new System.Windows.Forms.Button();
            this.lsbMoveLocation = new System.Windows.Forms.ListBox();
            this.btnChangeLookLocation = new System.Windows.Forms.Button();
            this.btnAddMoveLocation = new System.Windows.Forms.Button();
            this.btnMoveLocation = new System.Windows.Forms.Button();
            this.btnDeleteSelectedImages = new System.Windows.Forms.Button();
            this.picB = new System.Windows.Forms.PictureBox();
            this.txtNumberofImagesToShow = new System.Windows.Forms.TextBox();
            this.btnResetNumber = new System.Windows.Forms.Button();
            this.lblFileInfo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvImages
            // 
            this.lsvImages.Location = new System.Drawing.Point(5, 12);
            this.lsvImages.Name = "lsvImages";
            this.lsvImages.Size = new System.Drawing.Size(659, 550);
            this.lsvImages.TabIndex = 0;
            this.lsvImages.UseCompatibleStateImageBehavior = false;
            this.lsvImages.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(702, 42);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsbMoveLocation
            // 
            this.lsbMoveLocation.FormattingEnabled = true;
            this.lsbMoveLocation.Location = new System.Drawing.Point(783, 12);
            this.lsbMoveLocation.Name = "lsbMoveLocation";
            this.lsbMoveLocation.Size = new System.Drawing.Size(269, 108);
            this.lsbMoveLocation.TabIndex = 2;
            // 
            // btnChangeLookLocation
            // 
            this.btnChangeLookLocation.Location = new System.Drawing.Point(1055, 100);
            this.btnChangeLookLocation.Name = "btnChangeLookLocation";
            this.btnChangeLookLocation.Size = new System.Drawing.Size(132, 23);
            this.btnChangeLookLocation.TabIndex = 3;
            this.btnChangeLookLocation.Text = "Change Look Location";
            this.btnChangeLookLocation.UseVisualStyleBackColor = true;
            this.btnChangeLookLocation.Click += new System.EventHandler(this.btnChangeLookLocation_Click);
            // 
            // btnAddMoveLocation
            // 
            this.btnAddMoveLocation.Location = new System.Drawing.Point(1058, 13);
            this.btnAddMoveLocation.Name = "btnAddMoveLocation";
            this.btnAddMoveLocation.Size = new System.Drawing.Size(129, 23);
            this.btnAddMoveLocation.TabIndex = 4;
            this.btnAddMoveLocation.Text = "Add Move Location";
            this.btnAddMoveLocation.UseVisualStyleBackColor = true;
            this.btnAddMoveLocation.Click += new System.EventHandler(this.btnAddMoveLocation_Click);
            // 
            // btnMoveLocation
            // 
            this.btnMoveLocation.Location = new System.Drawing.Point(1058, 42);
            this.btnMoveLocation.Name = "btnMoveLocation";
            this.btnMoveLocation.Size = new System.Drawing.Size(129, 23);
            this.btnMoveLocation.TabIndex = 5;
            this.btnMoveLocation.Text = "Delete Move Location";
            this.btnMoveLocation.UseVisualStyleBackColor = true;
            this.btnMoveLocation.Click += new System.EventHandler(this.btnMoveLocation_Click);
            // 
            // btnDeleteSelectedImages
            // 
            this.btnDeleteSelectedImages.Location = new System.Drawing.Point(670, 13);
            this.btnDeleteSelectedImages.Name = "btnDeleteSelectedImages";
            this.btnDeleteSelectedImages.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteSelectedImages.TabIndex = 6;
            this.btnDeleteSelectedImages.Text = "Deleted Selected";
            this.btnDeleteSelectedImages.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedImages.Click += new System.EventHandler(this.btnDeleteSelectedImages_Click);
            // 
            // picB
            // 
            this.picB.InitialImage = null;
            this.picB.Location = new System.Drawing.Point(670, 138);
            this.picB.Name = "picB";
            this.picB.Size = new System.Drawing.Size(517, 424);
            this.picB.TabIndex = 7;
            this.picB.TabStop = false;
            // 
            // txtNumberofImagesToShow
            // 
            this.txtNumberofImagesToShow.Location = new System.Drawing.Point(1155, 74);
            this.txtNumberofImagesToShow.Name = "txtNumberofImagesToShow";
            this.txtNumberofImagesToShow.Size = new System.Drawing.Size(32, 20);
            this.txtNumberofImagesToShow.TabIndex = 8;
            this.txtNumberofImagesToShow.Text = "100";
            // 
            // btnResetNumber
            // 
            this.btnResetNumber.Location = new System.Drawing.Point(1058, 71);
            this.btnResetNumber.Name = "btnResetNumber";
            this.btnResetNumber.Size = new System.Drawing.Size(91, 23);
            this.btnResetNumber.TabIndex = 9;
            this.btnResetNumber.Text = "Reset Number";
            this.btnResetNumber.UseVisualStyleBackColor = true;
            this.btnResetNumber.Click += new System.EventHandler(this.btnResetNumber_Click);
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.AutoSize = true;
            this.lblFileInfo.Location = new System.Drawing.Point(670, 540);
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(50, 13);
            this.lblFileInfo.TabIndex = 10;
            this.lblFileInfo.Text = "File Info: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 576);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 598);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFileInfo);
            this.Controls.Add(this.btnResetNumber);
            this.Controls.Add(this.txtNumberofImagesToShow);
            this.Controls.Add(this.picB);
            this.Controls.Add(this.btnDeleteSelectedImages);
            this.Controls.Add(this.btnMoveLocation);
            this.Controls.Add(this.btnAddMoveLocation);
            this.Controls.Add(this.btnChangeLookLocation);
            this.Controls.Add(this.lsbMoveLocation);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lsvImages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvImages;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.ListBox lsbMoveLocation;
        private System.Windows.Forms.Button btnChangeLookLocation;
        private System.Windows.Forms.Button btnAddMoveLocation;
        private System.Windows.Forms.Button btnMoveLocation;
        private System.Windows.Forms.Button btnDeleteSelectedImages;
        //private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox picB;
        private System.Windows.Forms.TextBox txtNumberofImagesToShow;
        private System.Windows.Forms.Button btnResetNumber;
        private System.Windows.Forms.Label lblFileInfo;
        private System.Windows.Forms.Label lblStatus;


    }
}

