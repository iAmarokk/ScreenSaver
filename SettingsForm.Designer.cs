namespace ScreenSaver
{
    partial class SettingsForm
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
            this.labelBackTitle = new System.Windows.Forms.Label();
            this.labelForeTitle = new System.Windows.Forms.Label();
            this.labelForeColor = new System.Windows.Forms.Label();
            this.labelBackColor = new System.Windows.Forms.Label();
            this.labelCountTitle = new System.Windows.Forms.Label();
            this.trackBarCount = new System.Windows.Forms.TrackBar();
            this.labelCount = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBackTitle
            // 
            this.labelBackTitle.AutoSize = true;
            this.labelBackTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBackTitle.Location = new System.Drawing.Point(44, 9);
            this.labelBackTitle.Name = "labelBackTitle";
            this.labelBackTitle.Size = new System.Drawing.Size(103, 23);
            this.labelBackTitle.TabIndex = 0;
            this.labelBackTitle.Text = "Цвет фона";
            // 
            // labelForeTitle
            // 
            this.labelForeTitle.AutoSize = true;
            this.labelForeTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForeTitle.Location = new System.Drawing.Point(188, 9);
            this.labelForeTitle.Name = "labelForeTitle";
            this.labelForeTitle.Size = new System.Drawing.Size(113, 23);
            this.labelForeTitle.TabIndex = 1;
            this.labelForeTitle.Text = "Цвет линий";
            // 
            // labelForeColor
            // 
            this.labelForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelForeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForeColor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForeColor.Location = new System.Drawing.Point(222, 55);
            this.labelForeColor.Name = "labelForeColor";
            this.labelForeColor.Size = new System.Drawing.Size(40, 40);
            this.labelForeColor.TabIndex = 3;
            this.labelForeColor.Text = "  ";
            this.labelForeColor.Click += new System.EventHandler(this.LabelForeColor_Click);
            // 
            // labelBackColor
            // 
            this.labelBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBackColor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBackColor.Location = new System.Drawing.Point(76, 55);
            this.labelBackColor.Name = "labelBackColor";
            this.labelBackColor.Size = new System.Drawing.Size(40, 40);
            this.labelBackColor.TabIndex = 2;
            this.labelBackColor.Text = "  ";
            this.labelBackColor.Click += new System.EventHandler(this.LabelBackColor_Click);
            // 
            // labelCountTitle
            // 
            this.labelCountTitle.AutoSize = true;
            this.labelCountTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountTitle.Location = new System.Drawing.Point(12, 121);
            this.labelCountTitle.Name = "labelCountTitle";
            this.labelCountTitle.Size = new System.Drawing.Size(185, 23);
            this.labelCountTitle.TabIndex = 4;
            this.labelCountTitle.Text = "Количество вершин";
            // 
            // trackBarCount
            // 
            this.trackBarCount.Location = new System.Drawing.Point(16, 167);
            this.trackBarCount.Minimum = 2;
            this.trackBarCount.Name = "trackBarCount";
            this.trackBarCount.Size = new System.Drawing.Size(321, 45);
            this.trackBarCount.TabIndex = 5;
            this.trackBarCount.Value = 3;
            this.trackBarCount.Scroll += new System.EventHandler(this.TrackBarCount_Scroll);
            // 
            // labelCount
            // 
            this.labelCount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(253, 121);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(79, 23);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "3";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(38, 232);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(122, 32);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(192, 232);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 32);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 294);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.trackBarCount);
            this.Controls.Add(this.labelCountTitle);
            this.Controls.Add(this.labelForeColor);
            this.Controls.Add(this.labelBackColor);
            this.Controls.Add(this.labelForeTitle);
            this.Controls.Add(this.labelBackTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки хранителя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBackTitle;
        private System.Windows.Forms.Label labelForeTitle;
        private System.Windows.Forms.Label labelForeColor;
        private System.Windows.Forms.Label labelBackColor;
        private System.Windows.Forms.Label labelCountTitle;
        private System.Windows.Forms.TrackBar trackBarCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}