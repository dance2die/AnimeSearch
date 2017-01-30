namespace AnimeSearch
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvAnimeResult = new System.Windows.Forms.ListView();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(74, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(206, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search :";
            // 
            // lvAnimeResult
            // 
            this.lvAnimeResult.Location = new System.Drawing.Point(15, 96);
            this.lvAnimeResult.Name = "lvAnimeResult";
            this.lvAnimeResult.Size = new System.Drawing.Size(566, 360);
            this.lvAnimeResult.TabIndex = 2;
            this.lvAnimeResult.UseCompatibleStateImageBehavior = false;
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(481, 31);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(100, 20);
            this.tbUserID.TabIndex = 3;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(481, 70);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lvAnimeResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvAnimeResult;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

