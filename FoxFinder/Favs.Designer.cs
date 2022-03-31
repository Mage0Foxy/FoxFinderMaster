namespace FoxFinder
{
    partial class Favs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.GroupBox();
            this.game = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.book = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.video = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.output.SuspendLayout();
            this.game.SuspendLayout();
            this.book.SuspendLayout();
            this.video.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Controls.Add(this.game);
            this.output.Controls.Add(this.book);
            this.output.Controls.Add(this.video);
            this.output.Location = new System.Drawing.Point(157, 118);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(1662, 855);
            this.output.TabIndex = 21;
            this.output.TabStop = false;
            // 
            // game
            // 
            this.game.Controls.Add(this.label3);
            this.game.Controls.Add(this.vScrollBar3);
            this.game.Location = new System.Drawing.Point(6, 568);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(1656, 270);
            this.game.TabIndex = 2;
            this.game.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Games";
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(1634, 9);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(22, 261);
            this.vScrollBar3.TabIndex = 3;
            // 
            // book
            // 
            this.book.Controls.Add(this.label2);
            this.book.Controls.Add(this.vScrollBar2);
            this.book.Location = new System.Drawing.Point(6, 292);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(1656, 270);
            this.book.TabIndex = 1;
            this.book.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Books";
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(1634, 9);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(22, 261);
            this.vScrollBar2.TabIndex = 2;
            // 
            // video
            // 
            this.video.Controls.Add(this.label1);
            this.video.Controls.Add(this.vScrollBar1);
            this.video.Location = new System.Drawing.Point(6, 22);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(1656, 270);
            this.video.TabIndex = 0;
            this.video.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Videos";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1634, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(22, 261);
            this.vScrollBar1.TabIndex = 1;
            // 
            // Favs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.output);
            this.Name = "Favs";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.output.ResumeLayout(false);
            this.game.ResumeLayout(false);
            this.game.PerformLayout();
            this.book.ResumeLayout(false);
            this.book.PerformLayout();
            this.video.ResumeLayout(false);
            this.video.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox output;
        private GroupBox game;
        private Label label3;
        private VScrollBar vScrollBar3;
        private GroupBox book;
        private Label label2;
        private VScrollBar vScrollBar2;
        private GroupBox video;
        private Label label1;
        private VScrollBar vScrollBar1;
    }
}
