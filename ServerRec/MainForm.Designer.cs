
namespace ServerRec
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.boxLog = new System.Windows.Forms.GroupBox();
            this.testButton = new System.Windows.Forms.Button();
            this.buttonError = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextPort = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextIP = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.modelExploreButton = new System.Windows.Forms.Button();
            this.modelNameLabel = new System.Windows.Forms.Label();
            this.groupBoxModel = new System.Windows.Forms.GroupBox();
            this.checkBoxModel = new System.Windows.Forms.CheckBox();
            this.boxLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxModel.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox.Location = new System.Drawing.Point(6, 19);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(237, 187);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // buttonLog
            // 
            this.buttonLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLog.Location = new System.Drawing.Point(148, 224);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 29);
            this.buttonLog.TabIndex = 2;
            this.buttonLog.Text = "Скрыть Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRun.Location = new System.Drawing.Point(12, 224);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(130, 29);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Старт";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // boxLog
            // 
            this.boxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxLog.Controls.Add(this.testButton);
            this.boxLog.Controls.Add(this.buttonError);
            this.boxLog.Controls.Add(this.richTextBox);
            this.boxLog.Location = new System.Drawing.Point(241, 12);
            this.boxLog.Name = "boxLog";
            this.boxLog.Size = new System.Drawing.Size(249, 241);
            this.boxLog.TabIndex = 4;
            this.boxLog.TabStop = false;
            this.boxLog.Text = "Log:";
            // 
            // testButton
            // 
            this.testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testButton.Location = new System.Drawing.Point(6, 212);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(112, 23);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // buttonError
            // 
            this.buttonError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonError.Location = new System.Drawing.Point(131, 212);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(112, 23);
            this.buttonError.TabIndex = 1;
            this.buttonError.Text = "Open file errors log";
            this.buttonError.UseVisualStyleBackColor = true;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(133, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextPort);
            this.groupBox1.Controls.Add(this.maskedTextIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP-адрес и порт ПК:";
            // 
            // maskedTextPort
            // 
            this.maskedTextPort.Location = new System.Drawing.Point(145, 19);
            this.maskedTextPort.Mask = "00000";
            this.maskedTextPort.Name = "maskedTextPort";
            this.maskedTextPort.PromptChar = ' ';
            this.maskedTextPort.Size = new System.Drawing.Size(60, 20);
            this.maskedTextPort.TabIndex = 10;
            this.maskedTextPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextIP
            // 
            this.maskedTextIP.Location = new System.Drawing.Point(7, 19);
            this.maskedTextIP.Name = "maskedTextIP";
            this.maskedTextIP.PromptChar = ' ';
            this.maskedTextIP.Size = new System.Drawing.Size(123, 20);
            this.maskedTextIP.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя ассистента:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(115, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // modelExploreButton
            // 
            this.modelExploreButton.Location = new System.Drawing.Point(6, 43);
            this.modelExploreButton.Name = "modelExploreButton";
            this.modelExploreButton.Size = new System.Drawing.Size(104, 29);
            this.modelExploreButton.TabIndex = 12;
            this.modelExploreButton.Text = "Выбрать модель";
            this.modelExploreButton.UseVisualStyleBackColor = true;
            this.modelExploreButton.Click += new System.EventHandler(this.modelExploreButton_Click);
            // 
            // modelNameLabel
            // 
            this.modelNameLabel.AutoSize = true;
            this.modelNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.modelNameLabel.Location = new System.Drawing.Point(116, 49);
            this.modelNameLabel.Name = "modelNameLabel";
            this.modelNameLabel.Size = new System.Drawing.Size(51, 17);
            this.modelNameLabel.TabIndex = 13;
            this.modelNameLabel.Text = "model";
            // 
            // groupBoxModel
            // 
            this.groupBoxModel.Controls.Add(this.checkBoxModel);
            this.groupBoxModel.Controls.Add(this.modelExploreButton);
            this.groupBoxModel.Controls.Add(this.modelNameLabel);
            this.groupBoxModel.Location = new System.Drawing.Point(12, 94);
            this.groupBoxModel.Name = "groupBoxModel";
            this.groupBoxModel.Size = new System.Drawing.Size(223, 80);
            this.groupBoxModel.TabIndex = 14;
            this.groupBoxModel.TabStop = false;
            this.groupBoxModel.Text = "Выбор модели:";
            // 
            // checkBoxModel
            // 
            this.checkBoxModel.AutoSize = true;
            this.checkBoxModel.Checked = true;
            this.checkBoxModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxModel.Location = new System.Drawing.Point(7, 20);
            this.checkBoxModel.Name = "checkBoxModel";
            this.checkBoxModel.Size = new System.Drawing.Size(198, 17);
            this.checkBoxModel.TabIndex = 14;
            this.checkBoxModel.Text = "Использовать локальную модель";
            this.checkBoxModel.UseVisualStyleBackColor = true;
            this.checkBoxModel.CheckedChanged += new System.EventHandler(this.checkBoxModel_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 265);
            this.Controls.Add(this.groupBoxModel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxLog);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistant Server";
            this.boxLog.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxModel.ResumeLayout(false);
            this.groupBoxModel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox boxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextPort;
        private System.Windows.Forms.MaskedTextBox maskedTextIP;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button buttonError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button modelExploreButton;
        private System.Windows.Forms.Label modelNameLabel;
        private System.Windows.Forms.GroupBox groupBoxModel;
        private System.Windows.Forms.CheckBox checkBoxModel;
    }
}

