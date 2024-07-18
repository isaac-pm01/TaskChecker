namespace TaskChecker
{
    partial class Form1
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
            txtTitle = new TextBox();
            rtbBody = new RichTextBox();
            btnSave = new Button();
            btnEdit = new Button();
            cmbFont = new ComboBox();
            numFontSize = new NumericUpDown();
            btnColor = new Button();
            btnBold = new Button();
            btnItalic = new Button();
            btnUnderline = new Button();
            tvCategories = new TreeView();
            lvNotes = new ListView();
            ((System.ComponentModel.ISupportInitialize)numFontSize).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(108, 59);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(421, 23);
            txtTitle.TabIndex = 1;
            txtTitle.TextChanged += textBox1_TextChanged;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(108, 108);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(421, 227);
            rtbBody.TabIndex = 2;
            rtbBody.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(240, 356);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(163, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Guardar Nota";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(240, 398);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(163, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Editar Nota";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cmbFont
            // 
            cmbFont.FormattingEnabled = true;
            cmbFont.Location = new Point(0, 0);
            cmbFont.Name = "cmbFont";
            cmbFont.Size = new Size(121, 23);
            cmbFont.TabIndex = 5;
            // 
            // numFontSize
            // 
            numFontSize.Location = new Point(132, 1);
            numFontSize.Name = "numFontSize";
            numFontSize.Size = new Size(120, 23);
            numFontSize.TabIndex = 6;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(12, 108);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 7;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            // 
            // btnBold
            // 
            btnBold.Location = new Point(12, 165);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(75, 23);
            btnBold.TabIndex = 8;
            btnBold.Text = "Bold";
            btnBold.UseVisualStyleBackColor = true;
            // 
            // btnItalic
            // 
            btnItalic.Location = new Point(12, 221);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(75, 23);
            btnItalic.TabIndex = 9;
            btnItalic.Text = "Italic";
            btnItalic.UseVisualStyleBackColor = true;
            // 
            // btnUnderline
            // 
            btnUnderline.Location = new Point(12, 279);
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(75, 23);
            btnUnderline.TabIndex = 10;
            btnUnderline.Text = "Underline";
            btnUnderline.UseVisualStyleBackColor = true;
            // 
            // tvCategories
            // 
            tvCategories.Location = new Point(559, 241);
            tvCategories.Name = "tvCategories";
            tvCategories.Size = new Size(214, 94);
            tvCategories.TabIndex = 11;
            // 
            // lvNotes
            // 
            lvNotes.Location = new Point(559, 108);
            lvNotes.Name = "lvNotes";
            lvNotes.Size = new Size(214, 97);
            lvNotes.TabIndex = 12;
            lvNotes.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvNotes);
            Controls.Add(tvCategories);
            Controls.Add(btnUnderline);
            Controls.Add(btnItalic);
            Controls.Add(btnBold);
            Controls.Add(btnColor);
            Controls.Add(numFontSize);
            Controls.Add(cmbFont);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(rtbBody);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numFontSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private RichTextBox rtbBody;
        private Button btnSave;
        private Button btnEdit;
        private ComboBox cmbFont;
        private NumericUpDown numFontSize;
        private Button btnColor;
        private Button btnBold;
        private Button btnItalic;
        private Button btnUnderline;
        private TreeView tvCategories;
        private ListView lvNotes;
    }
}
