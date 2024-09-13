namespace EverydayCarry
{
    partial class EVDGadgetForm
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
            picBackground = new PictureBox();
            richOutput = new RichTextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnFind = new Button();
            btnCount = new Button();
            btnDisplayAll = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            SuspendLayout();
            // 
            // picBackground
            // 
            picBackground.Location = new Point(-1, -2);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(779, 578);
            picBackground.TabIndex = 0;
            picBackground.TabStop = false;
            // 
            // richOutput
            // 
            richOutput.Location = new Point(22, 12);
            richOutput.Name = "richOutput";
            richOutput.Size = new Size(344, 515);
            richOutput.TabIndex = 1;
            richOutput.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSkyBlue;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(470, 73);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(210, 45);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.LightSkyBlue;
            btnRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRemove.Location = new Point(470, 139);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(210, 45);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.LightSkyBlue;
            btnFind.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFind.Location = new Point(470, 202);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(210, 45);
            btnFind.TabIndex = 4;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnCount
            // 
            btnCount.BackColor = Color.LightSkyBlue;
            btnCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCount.Location = new Point(470, 266);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(210, 45);
            btnCount.TabIndex = 5;
            btnCount.Text = "COUNT";
            btnCount.UseVisualStyleBackColor = false;
            btnCount.Click += btnCount_Click;
            // 
            // btnDisplayAll
            // 
            btnDisplayAll.BackColor = Color.LightSkyBlue;
            btnDisplayAll.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDisplayAll.Location = new Point(470, 328);
            btnDisplayAll.Name = "btnDisplayAll";
            btnDisplayAll.Size = new Size(210, 45);
            btnDisplayAll.TabIndex = 9;
            btnDisplayAll.Text = "DISPLAY ALL";
            btnDisplayAll.UseVisualStyleBackColor = false;
            btnDisplayAll.Click += btnDisplayAll_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.Location = new Point(470, 390);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(210, 45);
            btnClear.TabIndex = 10;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // EVDGadgetForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 573);
            Controls.Add(btnClear);
            Controls.Add(btnDisplayAll);
            Controls.Add(btnCount);
            Controls.Add(btnFind);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(richOutput);
            Controls.Add(picBackground);
            Name = "EVDGadgetForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBackground;
        private RichTextBox richOutput;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnFind;
        private Button btnCount;
        private Button btnDisplayAll;
        private Button btnClear;
    }
}
