
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
            this.label = new System.Windows.Forms.Label();
            this.groupBoxIP = new System.Windows.Forms.GroupBox();
            this.maskedTextPort = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextIP = new System.Windows.Forms.MaskedTextBox();
            this.labelNameAss = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.modelExploreButton = new System.Windows.Forms.Button();
            this.modelNameLabel = new System.Windows.Forms.Label();
            this.groupBoxModel = new System.Windows.Forms.GroupBox();
            this.labelModelAdd = new System.Windows.Forms.Label();
            this.rb32 = new System.Windows.Forms.RadioButton();
            this.rb24 = new System.Windows.Forms.RadioButton();
            this.rb16 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.checkBoxModel = new System.Windows.Forms.CheckBox();
            this.mTBIPContr = new System.Windows.Forms.MaskedTextBox();
            this.labelIPContr = new System.Windows.Forms.Label();
            this.btStatus = new System.Windows.Forms.Button();
            this.boxLog.SuspendLayout();
            this.groupBoxIP.SuspendLayout();
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
            this.richTextBox.Size = new System.Drawing.Size(237, 237);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // buttonLog
            // 
            this.buttonLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLog.Location = new System.Drawing.Point(148, 274);
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
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRun.Location = new System.Drawing.Point(12, 274);
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
            this.boxLog.Size = new System.Drawing.Size(249, 291);
            this.boxLog.TabIndex = 4;
            this.boxLog.TabStop = false;
            this.boxLog.Text = "Log:";
            // 
            // testButton
            // 
            this.testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testButton.Location = new System.Drawing.Point(6, 262);
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
            this.buttonError.Location = new System.Drawing.Point(131, 262);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(112, 23);
            this.buttonError.TabIndex = 1;
            this.buttonError.Text = "Open file errors log";
            this.buttonError.UseVisualStyleBackColor = true;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(133, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(10, 15);
            this.label.TabIndex = 8;
            this.label.Text = ":";
            // 
            // groupBoxIP
            // 
            this.groupBoxIP.Controls.Add(this.maskedTextPort);
            this.groupBoxIP.Controls.Add(this.maskedTextIP);
            this.groupBoxIP.Controls.Add(this.label);
            this.groupBoxIP.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIP.Name = "groupBoxIP";
            this.groupBoxIP.Size = new System.Drawing.Size(211, 50);
            this.groupBoxIP.TabIndex = 9;
            this.groupBoxIP.TabStop = false;
            this.groupBoxIP.Text = "IP-адрес и порт сервера:";
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
            // labelNameAss
            // 
            this.labelNameAss.AutoSize = true;
            this.labelNameAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameAss.Location = new System.Drawing.Point(14, 68);
            this.labelNameAss.Name = "labelNameAss";
            this.labelNameAss.Size = new System.Drawing.Size(93, 13);
            this.labelNameAss.TabIndex = 10;
            this.labelNameAss.Text = "Имя ассистента:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(115, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // modelExploreButton
            // 
            this.modelExploreButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelExploreButton.Location = new System.Drawing.Point(6, 60);
            this.modelExploreButton.Name = "modelExploreButton";
            this.modelExploreButton.Size = new System.Drawing.Size(199, 26);
            this.modelExploreButton.TabIndex = 12;
            this.modelExploreButton.Text = "Выбрать модель";
            this.modelExploreButton.UseVisualStyleBackColor = true;
            this.modelExploreButton.Click += new System.EventHandler(this.modelExploreButton_Click);
            // 
            // modelNameLabel
            // 
            this.modelNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelNameLabel.AutoSize = true;
            this.modelNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.modelNameLabel.Location = new System.Drawing.Point(77, 39);
            this.modelNameLabel.Name = "modelNameLabel";
            this.modelNameLabel.Size = new System.Drawing.Size(47, 15);
            this.modelNameLabel.TabIndex = 13;
            this.modelNameLabel.Text = "model";
            // 
            // groupBoxModel
            // 
            this.groupBoxModel.Controls.Add(this.labelModelAdd);
            this.groupBoxModel.Controls.Add(this.rb32);
            this.groupBoxModel.Controls.Add(this.rb24);
            this.groupBoxModel.Controls.Add(this.rb16);
            this.groupBoxModel.Controls.Add(this.rb8);
            this.groupBoxModel.Controls.Add(this.checkBoxModel);
            this.groupBoxModel.Controls.Add(this.modelExploreButton);
            this.groupBoxModel.Controls.Add(this.modelNameLabel);
            this.groupBoxModel.Location = new System.Drawing.Point(12, 90);
            this.groupBoxModel.Name = "groupBoxModel";
            this.groupBoxModel.Size = new System.Drawing.Size(211, 115);
            this.groupBoxModel.TabIndex = 14;
            this.groupBoxModel.TabStop = false;
            this.groupBoxModel.Text = "Тип работы:";
            // 
            // labelModelAdd
            // 
            this.labelModelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModelAdd.AutoSize = true;
            this.labelModelAdd.Location = new System.Drawing.Point(4, 42);
            this.labelModelAdd.Name = "labelModelAdd";
            this.labelModelAdd.Size = new System.Drawing.Size(76, 13);
            this.labelModelAdd.TabIndex = 19;
            this.labelModelAdd.Text = "Имя модели: ";
            // 
            // rb32
            // 
            this.rb32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb32.AutoSize = true;
            this.rb32.Location = new System.Drawing.Point(156, 92);
            this.rb32.Name = "rb32";
            this.rb32.Size = new System.Drawing.Size(51, 17);
            this.rb32.TabIndex = 18;
            this.rb32.Text = "32 bit";
            this.rb32.UseVisualStyleBackColor = true;
            // 
            // rb24
            // 
            this.rb24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb24.AutoSize = true;
            this.rb24.Location = new System.Drawing.Point(105, 92);
            this.rb24.Name = "rb24";
            this.rb24.Size = new System.Drawing.Size(51, 17);
            this.rb24.TabIndex = 17;
            this.rb24.Text = "24 bit";
            this.rb24.UseVisualStyleBackColor = true;
            // 
            // rb16
            // 
            this.rb16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb16.AutoSize = true;
            this.rb16.Checked = true;
            this.rb16.Location = new System.Drawing.Point(53, 92);
            this.rb16.Name = "rb16";
            this.rb16.Size = new System.Drawing.Size(51, 17);
            this.rb16.TabIndex = 16;
            this.rb16.TabStop = true;
            this.rb16.Text = "16 bit";
            this.rb16.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(6, 92);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(45, 17);
            this.rb8.TabIndex = 15;
            this.rb8.Text = "8 bit";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // checkBoxModel
            // 
            this.checkBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // mTBIPContr
            // 
            this.mTBIPContr.Location = new System.Drawing.Point(110, 215);
            this.mTBIPContr.Name = "mTBIPContr";
            this.mTBIPContr.PromptChar = ' ';
            this.mTBIPContr.Size = new System.Drawing.Size(113, 20);
            this.mTBIPContr.TabIndex = 11;
            // 
            // labelIPContr
            // 
            this.labelIPContr.AutoSize = true;
            this.labelIPContr.Location = new System.Drawing.Point(16, 218);
            this.labelIPContr.Name = "labelIPContr";
            this.labelIPContr.Size = new System.Drawing.Size(88, 13);
            this.labelIPContr.TabIndex = 15;
            this.labelIPContr.Text = "IP контроллера:";
            // 
            // btStatus
            // 
            this.btStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btStatus.BackColor = System.Drawing.Color.LightGreen;
            this.btStatus.Enabled = false;
            this.btStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStatus.Location = new System.Drawing.Point(12, 244);
            this.btStatus.Name = "btStatus";
            this.btStatus.Size = new System.Drawing.Size(211, 24);
            this.btStatus.TabIndex = 16;
            this.btStatus.Text = "готово к работе";
            this.btStatus.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 315);
            this.Controls.Add(this.btStatus);
            this.Controls.Add(this.labelIPContr);
            this.Controls.Add(this.mTBIPContr);
            this.Controls.Add(this.groupBoxModel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNameAss);
            this.Controls.Add(this.groupBoxIP);
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
            this.groupBoxIP.ResumeLayout(false);
            this.groupBoxIP.PerformLayout();
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
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBoxIP;
        private System.Windows.Forms.MaskedTextBox maskedTextPort;
        private System.Windows.Forms.MaskedTextBox maskedTextIP;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button buttonError;
        private System.Windows.Forms.Label labelNameAss;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button modelExploreButton;
        private System.Windows.Forms.Label modelNameLabel;
        private System.Windows.Forms.GroupBox groupBoxModel;
        private System.Windows.Forms.CheckBox checkBoxModel;
        private System.Windows.Forms.RadioButton rb32;
        private System.Windows.Forms.RadioButton rb24;
        private System.Windows.Forms.RadioButton rb16;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.Label labelModelAdd;
        private System.Windows.Forms.MaskedTextBox mTBIPContr;
        private System.Windows.Forms.Label labelIPContr;
        private System.Windows.Forms.Button btStatus;
    }
}

