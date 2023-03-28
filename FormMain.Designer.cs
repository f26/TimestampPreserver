namespace TimestampPreserver
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxPath = new TextBox();
            buttonSave = new Button();
            buttonApply = new Button();
            checkBoxContinueOnError = new CheckBox();
            label1 = new Label();
            textBoxLog = new TextBox();
            label2 = new Label();
            buttonBrowse = new Button();
            SuspendLayout();
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(76, 12);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(400, 23);
            textBoxPath.TabIndex = 0;
            textBoxPath.Text = "C:\\Users";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(520, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(133, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += button1_Click;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(520, 40);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(133, 23);
            buttonApply.TabIndex = 2;
            buttonApply.Text = "Apply from File";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // checkBoxContinueOnError
            // 
            checkBoxContinueOnError.AutoSize = true;
            checkBoxContinueOnError.Location = new Point(393, 44);
            checkBoxContinueOnError.Name = "checkBoxContinueOnError";
            checkBoxContinueOnError.Size = new Size(120, 19);
            checkBoxContinueOnError.TabIndex = 3;
            checkBoxContinueOnError.Text = "Continue on error";
            checkBoxContinueOnError.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Directory:";
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(12, 69);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ReadOnly = true;
            textBoxLog.ScrollBars = ScrollBars.Vertical;
            textBoxLog.Size = new Size(641, 160);
            textBoxLog.TabIndex = 5;
            textBoxLog.Text = "Ready";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 6;
            label2.Text = "Log";
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(482, 12);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(32, 23);
            buttonBrowse.TabIndex = 7;
            buttonBrowse.Text = "...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 241);
            Controls.Add(buttonBrowse);
            Controls.Add(label2);
            Controls.Add(textBoxLog);
            Controls.Add(label1);
            Controls.Add(checkBoxContinueOnError);
            Controls.Add(buttonApply);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPath);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "TimestampPreserver";
            Load += FormMain_Load;
            Resize += FormMain_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPath;
        private Button buttonSave;
        private Button buttonApply;
        private CheckBox checkBoxContinueOnError;
        private Label label1;
        private TextBox textBoxLog;
        private Label label2;
        private Button buttonBrowse;
    }
}