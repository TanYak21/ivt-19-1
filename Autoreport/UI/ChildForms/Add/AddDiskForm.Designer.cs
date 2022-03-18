﻿
using System;
using System.Windows.Forms;

namespace Autoreport.UI
{
    partial class AddDiskForm : AddFormSelective
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
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.articleText = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.countText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.costText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeSelectedBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.selectedBox = new System.Windows.Forms.ListBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.flowLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayout
            // 
            this.flowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayout.Controls.Add(this.label1);
            this.flowLayout.Controls.Add(this.articleText);
            this.flowLayout.Controls.Add(this.label7);
            this.flowLayout.Controls.Add(this.countText);
            this.flowLayout.Controls.Add(this.label9);
            this.flowLayout.Controls.Add(this.costText);
            this.flowLayout.Controls.Add(this.label11);
            this.flowLayout.Controls.Add(this.panel1);
            this.flowLayout.Controls.Add(this.selectedBox);
            this.flowLayout.Location = new System.Drawing.Point(12, 12);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(476, 207);
            this.flowLayout.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.MinimumSize = new System.Drawing.Size(232, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Артикль";
            // 
            // articleText
            // 
            this.articleText.AsciiOnly = true;
            this.articleText.Location = new System.Drawing.Point(241, 3);
            this.articleText.Mask = "aaaaaa";
            this.articleText.Name = "articleText";
            this.articleText.Size = new System.Drawing.Size(232, 23);
            this.articleText.TabIndex = 15;
            this.articleText.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.MinimumSize = new System.Drawing.Size(232, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Количество";
            // 
            // countText
            // 
            this.countText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countText.Location = new System.Drawing.Point(241, 34);
            this.countText.Name = "countText";
            this.countText.Size = new System.Drawing.Size(232, 25);
            this.countText.TabIndex = 10;
            this.countText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitText_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.MinimumSize = new System.Drawing.Size(232, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Цена";
            // 
            // costText
            // 
            this.costText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costText.Location = new System.Drawing.Point(241, 65);
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(232, 25);
            this.costText.TabIndex = 11;
            this.costText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitText_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.MinimumSize = new System.Drawing.Size(232, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Фильмы";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeSelectedBtn);
            this.panel1.Controls.Add(this.selectBtn);
            this.panel1.Location = new System.Drawing.Point(241, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 49);
            this.panel1.TabIndex = 14;
            // 
            // removeSelectedBtn
            // 
            this.removeSelectedBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeSelectedBtn.Enabled = false;
            this.removeSelectedBtn.Location = new System.Drawing.Point(0, 26);
            this.removeSelectedBtn.Name = "removeSelectedBtn";
            this.removeSelectedBtn.Size = new System.Drawing.Size(75, 23);
            this.removeSelectedBtn.TabIndex = 13;
            this.removeSelectedBtn.Text = "Удалить";
            this.removeSelectedBtn.UseVisualStyleBackColor = true;
            this.removeSelectedBtn.Click += new System.EventHandler(this.RemoveSelectedBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectBtn.Location = new System.Drawing.Point(0, 0);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 12;
            this.selectBtn.Text = "Выбрать";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // selectedBox
            // 
            this.selectedBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedBox.FormattingEnabled = true;
            this.selectedBox.IntegralHeight = false;
            this.selectedBox.ItemHeight = 17;
            this.selectedBox.Location = new System.Drawing.Point(322, 96);
            this.selectedBox.Name = "selectedBox";
            this.selectedBox.Size = new System.Drawing.Size(151, 87);
            this.selectedBox.TabIndex = 13;
            this.selectedBox.SelectedIndexChanged += new System.EventHandler(this.SelectedBox_SelectedIndexChanged);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(12, 225);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(200, 30);
            this.resetBtn.TabIndex = 14;
            this.resetBtn.Text = "Сброс";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(288, 225);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(200, 30);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AddDiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 266);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.flowLayout);
            this.MaximumSize = new System.Drawing.Size(516, 500);
            this.MinimumSize = new System.Drawing.Size(516, 200);
            this.Name = "AddDiskForm";
            this.Text = "AddDiskForm";
            this.Load += new System.EventHandler(this.Form_Load);
            this.flowLayout.ResumeLayout(false);
            this.flowLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox countText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox costText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.ListBox selectedBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeSelectedBtn;
        private System.Windows.Forms.MaskedTextBox articleText;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
    }
}