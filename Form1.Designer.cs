namespace HouseBuilderApp
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
            this.comboBoxHouseType = new System.Windows.Forms.ComboBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.listBoxSteps = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxHouseType
            // 
            this.comboBoxHouseType.FormattingEnabled = true;
            this.comboBoxHouseType.Location = new System.Drawing.Point(139, 83);
            this.comboBoxHouseType.Name = "comboBoxHouseType";
            this.comboBoxHouseType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHouseType.TabIndex = 0;
            this.comboBoxHouseType.SelectedIndexChanged += new System.EventHandler(this.comboBoxHouseType_SelectedIndexChanged);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(12, 81);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 1;
            this.btnBuild.Text = "button1";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(286, 83);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(146, 46);
            this.txtResult.TabIndex = 2;
            // 
            // listBoxSteps
            // 
            this.listBoxSteps.FormattingEnabled = true;
            this.listBoxSteps.Location = new System.Drawing.Point(471, 81);
            this.listBoxSteps.Name = "listBoxSteps";
            this.listBoxSteps.Size = new System.Drawing.Size(159, 121);
            this.listBoxSteps.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxSteps);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.comboBoxHouseType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHouseType;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ListBox listBoxSteps;
    }
}

