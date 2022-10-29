﻿namespace SpendWise
{
    partial class Investments
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
            this.splitContainer_investments = new System.Windows.Forms.SplitContainer();
            this.lbl_progress = new MetroFramework.Controls.MetroLabel();
            this.scrollbar_progress = new MetroFramework.Controls.MetroScrollBar();
            this.txt_desc = new MetroFramework.Controls.MetroTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_amount = new MetroFramework.Controls.MetroTextBox();
            this.lbl_title_progress = new System.Windows.Forms.Label();
            this.lbl_title_description = new System.Windows.Forms.Label();
            this.lbl_title_amount = new System.Windows.Forms.Label();
            this.txt_investment = new MetroFramework.Controls.MetroTextBox();
            this.lbl_title_add = new System.Windows.Forms.Label();
            this.data_investments = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_investments)).BeginInit();
            this.splitContainer_investments.Panel1.SuspendLayout();
            this.splitContainer_investments.Panel2.SuspendLayout();
            this.splitContainer_investments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_investments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_investments
            // 
            this.splitContainer_investments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_investments.Location = new System.Drawing.Point(20, 60);
            this.splitContainer_investments.Name = "splitContainer_investments";
            // 
            // splitContainer_investments.Panel1
            // 
            this.splitContainer_investments.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer_investments.Panel1.Controls.Add(this.lbl_progress);
            this.splitContainer_investments.Panel1.Controls.Add(this.scrollbar_progress);
            this.splitContainer_investments.Panel1.Controls.Add(this.txt_desc);
            this.splitContainer_investments.Panel1.Controls.Add(this.txt_amount);
            this.splitContainer_investments.Panel1.Controls.Add(this.lbl_title_progress);
            this.splitContainer_investments.Panel1.Controls.Add(this.lbl_title_description);
            this.splitContainer_investments.Panel1.Controls.Add(this.lbl_title_amount);
            this.splitContainer_investments.Panel1.Controls.Add(this.txt_investment);
            this.splitContainer_investments.Panel1.Controls.Add(this.lbl_title_add);
            // 
            // splitContainer_investments.Panel2
            // 
            this.splitContainer_investments.Panel2.Controls.Add(this.data_investments);
            this.splitContainer_investments.Size = new System.Drawing.Size(638, 395);
            this.splitContainer_investments.SplitterDistance = 187;
            this.splitContainer_investments.TabIndex = 0;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_progress.Location = new System.Drawing.Point(9, 297);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(35, 25);
            this.lbl_progress.Style = MetroFramework.MetroColorStyle.Green;
            this.lbl_progress.TabIndex = 5;
            this.lbl_progress.Text = "0%";
            this.lbl_progress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // scrollbar_progress
            // 
            this.scrollbar_progress.LargeChange = 10;
            this.scrollbar_progress.Location = new System.Drawing.Point(9, 336);
            this.scrollbar_progress.Maximum = 100;
            this.scrollbar_progress.Minimum = 0;
            this.scrollbar_progress.MouseWheelBarPartitions = 10;
            this.scrollbar_progress.Name = "scrollbar_progress";
            this.scrollbar_progress.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.scrollbar_progress.ScrollbarSize = 10;
            this.scrollbar_progress.Size = new System.Drawing.Size(167, 10);
            this.scrollbar_progress.Style = MetroFramework.MetroColorStyle.Green;
            this.scrollbar_progress.TabIndex = 3;
            this.scrollbar_progress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.scrollbar_progress.UseSelectable = true;
            this.scrollbar_progress.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scrollbar_progress_Scroll);
            // 
            // txt_desc
            // 
            // 
            // 
            // 
            this.txt_desc.CustomButton.Image = null;
            this.txt_desc.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.txt_desc.CustomButton.Name = "";
            this.txt_desc.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txt_desc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_desc.CustomButton.TabIndex = 1;
            this.txt_desc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_desc.CustomButton.UseSelectable = true;
            this.txt_desc.CustomButton.Visible = false;
            this.txt_desc.Lines = new string[0];
            this.txt_desc.Location = new System.Drawing.Point(8, 163);
            this.txt_desc.MaxLength = 32767;
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.PasswordChar = '\0';
            this.txt_desc.PromptText = "Optional but important...";
            this.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_desc.SelectedText = "";
            this.txt_desc.SelectionLength = 0;
            this.txt_desc.SelectionStart = 0;
            this.txt_desc.ShortcutsEnabled = true;
            this.txt_desc.Size = new System.Drawing.Size(167, 100);
            this.txt_desc.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_desc.TabIndex = 2;
            this.txt_desc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_desc.UseSelectable = true;
            this.txt_desc.WaterMark = "Optional but important...";
            this.txt_desc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_desc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 31);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // txt_amount
            // 
            // 
            // 
            // 
            this.txt_amount.CustomButton.Image = null;
            this.txt_amount.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txt_amount.CustomButton.Name = "";
            this.txt_amount.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_amount.CustomButton.TabIndex = 1;
            this.txt_amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_amount.CustomButton.UseSelectable = true;
            this.txt_amount.CustomButton.Visible = false;
            this.txt_amount.DisplayIcon = true;
            this.txt_amount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_amount.Lines = new string[0];
            this.txt_amount.Location = new System.Drawing.Point(8, 98);
            this.txt_amount.MaxLength = 32767;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.PasswordChar = '\0';
            this.txt_amount.PromptText = "Set cost...";
            this.txt_amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_amount.SelectedText = "";
            this.txt_amount.SelectionLength = 0;
            this.txt_amount.SelectionStart = 0;
            this.txt_amount.ShortcutsEnabled = true;
            this.txt_amount.ShowClearButton = true;
            this.txt_amount.Size = new System.Drawing.Size(167, 29);
            this.txt_amount.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_amount.TabIndex = 1;
            this.txt_amount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_amount.UseSelectable = true;
            this.txt_amount.WaterMark = "Set cost...";
            this.txt_amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MetroTextBox1_KeyPress);
            // 
            // lbl_title_progress
            // 
            this.lbl_title_progress.AutoSize = true;
            this.lbl_title_progress.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_title_progress.ForeColor = System.Drawing.Color.White;
            this.lbl_title_progress.Location = new System.Drawing.Point(3, 266);
            this.lbl_title_progress.Name = "lbl_title_progress";
            this.lbl_title_progress.Size = new System.Drawing.Size(85, 25);
            this.lbl_title_progress.TabIndex = 0;
            this.lbl_title_progress.Text = "Progress";
            // 
            // lbl_title_description
            // 
            this.lbl_title_description.AutoSize = true;
            this.lbl_title_description.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_title_description.ForeColor = System.Drawing.Color.White;
            this.lbl_title_description.Location = new System.Drawing.Point(3, 130);
            this.lbl_title_description.Name = "lbl_title_description";
            this.lbl_title_description.Size = new System.Drawing.Size(108, 25);
            this.lbl_title_description.TabIndex = 0;
            this.lbl_title_description.Text = "Description";
            // 
            // lbl_title_amount
            // 
            this.lbl_title_amount.AutoSize = true;
            this.lbl_title_amount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_title_amount.ForeColor = System.Drawing.Color.White;
            this.lbl_title_amount.Location = new System.Drawing.Point(3, 65);
            this.lbl_title_amount.Name = "lbl_title_amount";
            this.lbl_title_amount.Size = new System.Drawing.Size(79, 25);
            this.lbl_title_amount.TabIndex = 0;
            this.lbl_title_amount.Text = "Amount";
            // 
            // txt_investment
            // 
            // 
            // 
            // 
            this.txt_investment.CustomButton.Image = null;
            this.txt_investment.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txt_investment.CustomButton.Name = "";
            this.txt_investment.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_investment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_investment.CustomButton.TabIndex = 1;
            this.txt_investment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_investment.CustomButton.UseSelectable = true;
            this.txt_investment.CustomButton.Visible = false;
            this.txt_investment.DisplayIcon = true;
            this.txt_investment.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_investment.Lines = new string[0];
            this.txt_investment.Location = new System.Drawing.Point(8, 33);
            this.txt_investment.MaxLength = 32767;
            this.txt_investment.Name = "txt_investment";
            this.txt_investment.PasswordChar = '\0';
            this.txt_investment.PromptText = "Set title...";
            this.txt_investment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_investment.SelectedText = "";
            this.txt_investment.SelectionLength = 0;
            this.txt_investment.SelectionStart = 0;
            this.txt_investment.ShortcutsEnabled = true;
            this.txt_investment.ShowClearButton = true;
            this.txt_investment.Size = new System.Drawing.Size(167, 29);
            this.txt_investment.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_investment.TabIndex = 0;
            this.txt_investment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_investment.UseSelectable = true;
            this.txt_investment.WaterMark = "Set title...";
            this.txt_investment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_investment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_title_add
            // 
            this.lbl_title_add.AutoSize = true;
            this.lbl_title_add.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_title_add.ForeColor = System.Drawing.Color.White;
            this.lbl_title_add.Location = new System.Drawing.Point(3, 0);
            this.lbl_title_add.Name = "lbl_title_add";
            this.lbl_title_add.Size = new System.Drawing.Size(46, 25);
            this.lbl_title_add.TabIndex = 0;
            this.lbl_title_add.Text = "Add";
            // 
            // data_investments
            // 
            this.data_investments.AllowUserToAddRows = false;
            this.data_investments.AllowUserToDeleteRows = false;
            this.data_investments.AllowUserToResizeRows = false;
            this.data_investments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.data_investments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_investments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_investments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_investments.Location = new System.Drawing.Point(0, 0);
            this.data_investments.Name = "data_investments";
            this.data_investments.ReadOnly = true;
            this.data_investments.Size = new System.Drawing.Size(447, 395);
            this.data_investments.TabIndex = 5;
            this.data_investments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_investments_CellClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 364);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_add);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_update);
            this.splitContainer1.Size = new System.Drawing.Size(187, 31);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 6;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(0, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 31);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Investments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 475);
            this.Controls.Add(this.splitContainer_investments);
            this.MaximizeBox = false;
            this.Name = "Investments";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Investments";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Investments_Load);
            this.splitContainer_investments.Panel1.ResumeLayout(false);
            this.splitContainer_investments.Panel1.PerformLayout();
            this.splitContainer_investments.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_investments)).EndInit();
            this.splitContainer_investments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_investments)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_investments;
        private System.Windows.Forms.Label lbl_title_add;
        private System.Windows.Forms.DataGridView data_investments;
        private MetroFramework.Controls.MetroTextBox txt_amount;
        private System.Windows.Forms.Label lbl_title_amount;
        private MetroFramework.Controls.MetroTextBox txt_investment;
        private System.Windows.Forms.Button btn_add;
        private MetroFramework.Controls.MetroTextBox txt_desc;
        private System.Windows.Forms.Label lbl_title_description;
        private MetroFramework.Controls.MetroLabel lbl_progress;
        private MetroFramework.Controls.MetroScrollBar scrollbar_progress;
        private System.Windows.Forms.Label lbl_title_progress;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_update;
    }
}