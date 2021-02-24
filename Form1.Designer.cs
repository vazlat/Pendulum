
namespace Pendulum
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxStabilizationLines = new System.Windows.Forms.CheckBox();
            this.checkBoxStabilizationSplain = new System.Windows.Forms.CheckBox();
            this.checkBoxStabilizationPoints = new System.Windows.Forms.CheckBox();
            this.checkBoxFlipLines = new System.Windows.Forms.CheckBox();
            this.checkBoxFlipSplain = new System.Windows.Forms.CheckBox();
            this.checkBoxFlipPoints = new System.Windows.Forms.CheckBox();
            this.comboBoxStabilizationZerPoint = new System.Windows.Forms.ComboBox();
            this.comboBoxFlipZerPoint = new System.Windows.Forms.ComboBox();
            this.rTxtTest = new System.Windows.Forms.RichTextBox();
            this.rTxtStabilization = new System.Windows.Forms.RichTextBox();
            this.rTxtFlip = new System.Windows.Forms.RichTextBox();
            this.panelStabilization = new System.Windows.Forms.Panel();
            this.panelFlip = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxStabilizationLines
            // 
            this.checkBoxStabilizationLines.AutoSize = true;
            this.checkBoxStabilizationLines.Checked = true;
            this.checkBoxStabilizationLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStabilizationLines.Location = new System.Drawing.Point(1186, 479);
            this.checkBoxStabilizationLines.Name = "checkBoxStabilizationLines";
            this.checkBoxStabilizationLines.Size = new System.Drawing.Size(58, 17);
            this.checkBoxStabilizationLines.TabIndex = 27;
            this.checkBoxStabilizationLines.Text = "Линии";
            this.checkBoxStabilizationLines.UseVisualStyleBackColor = true;
            this.checkBoxStabilizationLines.CheckedChanged += new System.EventHandler(this.checkBoxStabilizationLines_CheckedChanged);
            // 
            // checkBoxStabilizationSplain
            // 
            this.checkBoxStabilizationSplain.AutoSize = true;
            this.checkBoxStabilizationSplain.Checked = true;
            this.checkBoxStabilizationSplain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStabilizationSplain.Location = new System.Drawing.Point(1117, 479);
            this.checkBoxStabilizationSplain.Name = "checkBoxStabilizationSplain";
            this.checkBoxStabilizationSplain.Size = new System.Drawing.Size(63, 17);
            this.checkBoxStabilizationSplain.TabIndex = 26;
            this.checkBoxStabilizationSplain.Text = "Сплайн";
            this.checkBoxStabilizationSplain.UseVisualStyleBackColor = true;
            this.checkBoxStabilizationSplain.CheckedChanged += new System.EventHandler(this.checkBoxStabilizationSplain_CheckedChanged);
            // 
            // checkBoxStabilizationPoints
            // 
            this.checkBoxStabilizationPoints.AutoSize = true;
            this.checkBoxStabilizationPoints.Checked = true;
            this.checkBoxStabilizationPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStabilizationPoints.Location = new System.Drawing.Point(1055, 479);
            this.checkBoxStabilizationPoints.Name = "checkBoxStabilizationPoints";
            this.checkBoxStabilizationPoints.Size = new System.Drawing.Size(56, 17);
            this.checkBoxStabilizationPoints.TabIndex = 25;
            this.checkBoxStabilizationPoints.Text = "Точки";
            this.checkBoxStabilizationPoints.UseVisualStyleBackColor = true;
            this.checkBoxStabilizationPoints.CheckedChanged += new System.EventHandler(this.checkBoxStabilizationPoints_CheckedChanged);
            // 
            // checkBoxFlipLines
            // 
            this.checkBoxFlipLines.AutoSize = true;
            this.checkBoxFlipLines.Checked = true;
            this.checkBoxFlipLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFlipLines.Location = new System.Drawing.Point(290, 479);
            this.checkBoxFlipLines.Name = "checkBoxFlipLines";
            this.checkBoxFlipLines.Size = new System.Drawing.Size(58, 17);
            this.checkBoxFlipLines.TabIndex = 24;
            this.checkBoxFlipLines.Text = "Линии";
            this.checkBoxFlipLines.UseVisualStyleBackColor = true;
            this.checkBoxFlipLines.CheckedChanged += new System.EventHandler(this.checkBoxFlipLines_CheckedChanged);
            // 
            // checkBoxFlipSplain
            // 
            this.checkBoxFlipSplain.AutoSize = true;
            this.checkBoxFlipSplain.Checked = true;
            this.checkBoxFlipSplain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFlipSplain.Location = new System.Drawing.Point(221, 479);
            this.checkBoxFlipSplain.Name = "checkBoxFlipSplain";
            this.checkBoxFlipSplain.Size = new System.Drawing.Size(63, 17);
            this.checkBoxFlipSplain.TabIndex = 23;
            this.checkBoxFlipSplain.Text = "Сплайн";
            this.checkBoxFlipSplain.UseVisualStyleBackColor = true;
            this.checkBoxFlipSplain.CheckedChanged += new System.EventHandler(this.checkBoxFlipSplain_CheckedChanged);
            // 
            // checkBoxFlipPoints
            // 
            this.checkBoxFlipPoints.AutoSize = true;
            this.checkBoxFlipPoints.Checked = true;
            this.checkBoxFlipPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFlipPoints.Location = new System.Drawing.Point(159, 479);
            this.checkBoxFlipPoints.Name = "checkBoxFlipPoints";
            this.checkBoxFlipPoints.Size = new System.Drawing.Size(56, 17);
            this.checkBoxFlipPoints.TabIndex = 22;
            this.checkBoxFlipPoints.Text = "Точки";
            this.checkBoxFlipPoints.UseVisualStyleBackColor = true;
            this.checkBoxFlipPoints.CheckedChanged += new System.EventHandler(this.checkBoxFlipPoints_CheckedChanged);
            // 
            // comboBoxStabilizationZerPoint
            // 
            this.comboBoxStabilizationZerPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStabilizationZerPoint.FormattingEnabled = true;
            this.comboBoxStabilizationZerPoint.Items.AddRange(new object[] {
            "center",
            "left",
            "leftBottom",
            "leftTop",
            "right",
            "rightBottom",
            "rightTop",
            "top",
            "bottom"});
            this.comboBoxStabilizationZerPoint.Location = new System.Drawing.Point(907, 477);
            this.comboBoxStabilizationZerPoint.Name = "comboBoxStabilizationZerPoint";
            this.comboBoxStabilizationZerPoint.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStabilizationZerPoint.TabIndex = 21;
            this.comboBoxStabilizationZerPoint.SelectedIndexChanged += new System.EventHandler(this.comboBoxStabilizationZerPoint_SelectedIndexChanged);
            // 
            // comboBoxFlipZerPoint
            // 
            this.comboBoxFlipZerPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlipZerPoint.FormattingEnabled = true;
            this.comboBoxFlipZerPoint.Items.AddRange(new object[] {
            "center",
            "left",
            "leftBottom",
            "leftTop",
            "right",
            "rightBottom",
            "rightTop",
            "top",
            "bottom"});
            this.comboBoxFlipZerPoint.Location = new System.Drawing.Point(13, 477);
            this.comboBoxFlipZerPoint.Name = "comboBoxFlipZerPoint";
            this.comboBoxFlipZerPoint.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFlipZerPoint.TabIndex = 20;
            this.comboBoxFlipZerPoint.SelectedIndexChanged += new System.EventHandler(this.comboBoxFlipZerPoint_SelectedIndexChanged);
            // 
            // rTxtTest
            // 
            this.rTxtTest.Location = new System.Drawing.Point(743, 12);
            this.rTxtTest.Name = "rTxtTest";
            this.rTxtTest.Size = new System.Drawing.Size(158, 446);
            this.rTxtTest.TabIndex = 19;
            this.rTxtTest.Text = "";
            // 
            // rTxtStabilization
            // 
            this.rTxtStabilization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rTxtStabilization.Location = new System.Drawing.Point(907, 520);
            this.rTxtStabilization.Name = "rTxtStabilization";
            this.rTxtStabilization.Size = new System.Drawing.Size(725, 50);
            this.rTxtStabilization.TabIndex = 18;
            this.rTxtStabilization.Text = "";
            // 
            // rTxtFlip
            // 
            this.rTxtFlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rTxtFlip.Location = new System.Drawing.Point(12, 520);
            this.rTxtFlip.Name = "rTxtFlip";
            this.rTxtFlip.Size = new System.Drawing.Size(725, 50);
            this.rTxtFlip.TabIndex = 17;
            this.rTxtFlip.Text = "";
            // 
            // panelStabilization
            // 
            this.panelStabilization.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelStabilization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelStabilization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStabilization.Location = new System.Drawing.Point(907, 12);
            this.panelStabilization.Name = "panelStabilization";
            this.panelStabilization.Size = new System.Drawing.Size(725, 446);
            this.panelStabilization.TabIndex = 16;
            // 
            // panelFlip
            // 
            this.panelFlip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelFlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFlip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFlip.Location = new System.Drawing.Point(12, 12);
            this.panelFlip.Name = "panelFlip";
            this.panelFlip.Size = new System.Drawing.Size(725, 446);
            this.panelFlip.TabIndex = 15;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(777, 477);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 37);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 582);
            this.Controls.Add(this.checkBoxStabilizationLines);
            this.Controls.Add(this.checkBoxStabilizationSplain);
            this.Controls.Add(this.checkBoxStabilizationPoints);
            this.Controls.Add(this.checkBoxFlipLines);
            this.Controls.Add(this.checkBoxFlipSplain);
            this.Controls.Add(this.checkBoxFlipPoints);
            this.Controls.Add(this.comboBoxStabilizationZerPoint);
            this.Controls.Add(this.comboBoxFlipZerPoint);
            this.Controls.Add(this.rTxtTest);
            this.Controls.Add(this.rTxtStabilization);
            this.Controls.Add(this.rTxtFlip);
            this.Controls.Add(this.panelStabilization);
            this.Controls.Add(this.panelFlip);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxStabilizationLines;
        private System.Windows.Forms.CheckBox checkBoxStabilizationSplain;
        private System.Windows.Forms.CheckBox checkBoxStabilizationPoints;
        private System.Windows.Forms.CheckBox checkBoxFlipLines;
        private System.Windows.Forms.CheckBox checkBoxFlipSplain;
        private System.Windows.Forms.CheckBox checkBoxFlipPoints;
        private System.Windows.Forms.ComboBox comboBoxStabilizationZerPoint;
        private System.Windows.Forms.ComboBox comboBoxFlipZerPoint;
        private System.Windows.Forms.RichTextBox rTxtTest;
        private System.Windows.Forms.RichTextBox rTxtStabilization;
        private System.Windows.Forms.RichTextBox rTxtFlip;
        private System.Windows.Forms.Panel panelStabilization;
        private System.Windows.Forms.Panel panelFlip;
        private System.Windows.Forms.Button btnStart;
    }
}

