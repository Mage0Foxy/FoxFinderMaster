namespace FoxFinder
{
    partial class Add_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Edit));
            this.IMG_Add = new System.Windows.Forms.PictureBox();
            this.Media_playable = new System.Windows.Forms.TextBox();
            this.Media_description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Media_title = new System.Windows.Forms.TextBox();
            this.Media_type = new System.Windows.Forms.ComboBox();
            this.Media_category = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.save2db = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG_Add
            // 
            this.IMG_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.IMG_Add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMG_Add.Location = new System.Drawing.Point(12, 12);
            this.IMG_Add.Name = "IMG_Add";
            this.IMG_Add.Size = new System.Drawing.Size(150, 150);
            this.IMG_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IMG_Add.TabIndex = 0;
            this.IMG_Add.TabStop = false;
            // 
            // Media_playable
            // 
            this.Media_playable.Location = new System.Drawing.Point(451, 12);
            this.Media_playable.Name = "Media_playable";
            this.Media_playable.Size = new System.Drawing.Size(169, 23);
            this.Media_playable.TabIndex = 1;
            this.Media_playable.Text = "URL";
            // 
            // Media_description
            // 
            this.Media_description.Location = new System.Drawing.Point(168, 61);
            this.Media_description.Name = "Media_description";
            this.Media_description.Size = new System.Drawing.Size(277, 101);
            this.Media_description.TabIndex = 2;
            this.Media_description.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // Media_title
            // 
            this.Media_title.Location = new System.Drawing.Point(168, 12);
            this.Media_title.Name = "Media_title";
            this.Media_title.Size = new System.Drawing.Size(277, 23);
            this.Media_title.TabIndex = 4;
            this.Media_title.Text = "Name";
            // 
            // Media_type
            // 
            this.Media_type.FormattingEnabled = true;
            this.Media_type.Location = new System.Drawing.Point(626, 12);
            this.Media_type.Name = "Media_type";
            this.Media_type.Size = new System.Drawing.Size(121, 23);
            this.Media_type.TabIndex = 5;
            // 
            // Media_category
            // 
            this.Media_category.FormattingEnabled = true;
            this.Media_category.Location = new System.Drawing.Point(626, 41);
            this.Media_category.Name = "Media_category";
            this.Media_category.Size = new System.Drawing.Size(121, 23);
            this.Media_category.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(666, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // save2db
            // 
            this.save2db.Location = new System.Drawing.Point(12, 408);
            this.save2db.Name = "save2db";
            this.save2db.Size = new System.Drawing.Size(75, 23);
            this.save2db.TabIndex = 11;
            this.save2db.Text = "Save";
            this.save2db.UseVisualStyleBackColor = true;
            this.save2db.Click += new System.EventHandler(this.save2db_Click);
            // 
            // Add_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 501);
            this.Controls.Add(this.save2db);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Media_category);
            this.Controls.Add(this.Media_type);
            this.Controls.Add(this.Media_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Media_description);
            this.Controls.Add(this.Media_playable);
            this.Controls.Add(this.IMG_Add);
            this.Name = "Add_Edit";
            this.Text = "Add_Edit";
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox IMG_Add;
        private TextBox Media_playable;
        private RichTextBox Media_description;
        private Label label1;
        private TextBox Media_title;
        private ComboBox Media_type;
        private ComboBox Media_category;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button save2db;
    }
}