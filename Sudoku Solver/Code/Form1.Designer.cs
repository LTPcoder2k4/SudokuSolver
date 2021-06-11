
namespace Sudoku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.importBtn = new Sudoku.RJButton();
            this.solveBtn = new Sudoku.RJButton();
            this.newBtn = new Sudoku.RJButton();
            this.sudokuBox = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Controls.Add(this.importBtn);
            this.groupBox2.Controls.Add(this.solveBtn);
            this.groupBox2.Controls.Add(this.newBtn);
            this.groupBox2.Font = new System.Drawing.Font("GamePixies", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox2.Location = new System.Drawing.Point(610, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 426);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Handle";
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.importBtn.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.importBtn.BorderColor = System.Drawing.Color.Indigo;
            this.importBtn.BorderRadius = 40;
            this.importBtn.BorderSize = 3;
            this.importBtn.FlatAppearance.BorderSize = 0;
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importBtn.ForeColor = System.Drawing.Color.White;
            this.importBtn.Location = new System.Drawing.Point(6, 293);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(166, 54);
            this.importBtn.TabIndex = 2;
            this.importBtn.Text = "Import";
            this.importBtn.TextColor = System.Drawing.Color.White;
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // solveBtn
            // 
            this.solveBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.solveBtn.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.solveBtn.BorderColor = System.Drawing.Color.Indigo;
            this.solveBtn.BorderRadius = 40;
            this.solveBtn.BorderSize = 3;
            this.solveBtn.FlatAppearance.BorderSize = 0;
            this.solveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solveBtn.ForeColor = System.Drawing.Color.White;
            this.solveBtn.Location = new System.Drawing.Point(6, 182);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(166, 54);
            this.solveBtn.TabIndex = 1;
            this.solveBtn.Text = "Solve";
            this.solveBtn.TextColor = System.Drawing.Color.White;
            this.solveBtn.UseVisualStyleBackColor = false;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.newBtn.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.newBtn.BorderColor = System.Drawing.Color.Indigo;
            this.newBtn.BorderRadius = 40;
            this.newBtn.BorderSize = 3;
            this.newBtn.FlatAppearance.BorderSize = 0;
            this.newBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtn.ForeColor = System.Drawing.Color.White;
            this.newBtn.Location = new System.Drawing.Point(6, 72);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(166, 54);
            this.newBtn.TabIndex = 0;
            this.newBtn.Text = "New";
            this.newBtn.TextColor = System.Drawing.Color.White;
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // sudokuBox
            // 
            this.sudokuBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.sudokuBox.Font = new System.Drawing.Font("GamePixies", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sudokuBox.ForeColor = System.Drawing.Color.Cyan;
            this.sudokuBox.Location = new System.Drawing.Point(12, 12);
            this.sudokuBox.Name = "sudokuBox";
            this.sudokuBox.Size = new System.Drawing.Size(592, 426);
            this.sudokuBox.TabIndex = 2;
            this.sudokuBox.TabStop = false;
            this.sudokuBox.Text = "Sudoku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sudokuBox);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku Solver";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox sudokuBox;
        private RJButton solveBtn;
        private RJButton newBtn;
        private RJButton importBtn;
    }
}

