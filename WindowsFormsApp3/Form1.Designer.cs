namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            this.lbRule = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.edRule = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            this.tabl = new System.Windows.Forms.TableLayoutPanel();
            this.lb0 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edRule)).BeginInit();
            this.tabl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRule
            // 
            this.lbRule.AutoSize = true;
            this.lbRule.Location = new System.Drawing.Point(12, 9);
            this.lbRule.Name = "lbRule";
            this.lbRule.Size = new System.Drawing.Size(76, 20);
            this.lbRule.TabIndex = 0;
            this.lbRule.Text = "Правило";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(4, 83);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(0, 20);
            this.lb2.TabIndex = 1;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edRule
            // 
            this.edRule.Location = new System.Drawing.Point(94, 7);
            this.edRule.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.edRule.Name = "edRule";
            this.edRule.Size = new System.Drawing.Size(83, 26);
            this.edRule.TabIndex = 2;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(16, 52);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(161, 43);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tabl
            // 
            this.tabl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tabl.ColumnCount = 14;
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tabl.Controls.Add(this.lb0, 0, 0);
            this.tabl.Controls.Add(this.lb1, 0, 1);
            this.tabl.Controls.Add(this.lb2, 0, 2);
            this.tabl.Controls.Add(this.lb3, 0, 3);
            this.tabl.Controls.Add(this.lb4, 0, 4);
            this.tabl.Controls.Add(this.lb5, 0, 5);
            this.tabl.Controls.Add(this.lb6, 0, 6);
            this.tabl.Controls.Add(this.lb7, 0, 7);
            this.tabl.Controls.Add(this.lb8, 0, 8);
            this.tabl.Controls.Add(this.lb9, 0, 9);
            this.tabl.Controls.Add(this.lb10, 0, 10);
            this.tabl.Controls.Add(this.lb11, 0, 11);
            this.tabl.Controls.Add(this.lb12, 0, 12);
            this.tabl.Location = new System.Drawing.Point(210, 9);
            this.tabl.Name = "tabl";
            this.tabl.RowCount = 13;
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tabl.Size = new System.Drawing.Size(592, 570);
            this.tabl.TabIndex = 4;
            this.tabl.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tabl_CellPaint);
            // 
            // lb0
            // 
            this.lb0.AutoSize = true;
            this.lb0.Location = new System.Drawing.Point(4, 1);
            this.lb0.Name = "lb0";
            this.lb0.Size = new System.Drawing.Size(0, 20);
            this.lb0.TabIndex = 2;
            this.lb0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(4, 42);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 20);
            this.lb1.TabIndex = 3;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(4, 124);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(0, 20);
            this.lb3.TabIndex = 4;
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(4, 165);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(0, 20);
            this.lb4.TabIndex = 5;
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(4, 206);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(0, 20);
            this.lb5.TabIndex = 6;
            this.lb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(4, 247);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(0, 20);
            this.lb6.TabIndex = 7;
            this.lb6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Location = new System.Drawing.Point(4, 288);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(0, 20);
            this.lb7.TabIndex = 8;
            this.lb7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(4, 329);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(0, 20);
            this.lb8.TabIndex = 9;
            this.lb8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.Location = new System.Drawing.Point(4, 370);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(0, 20);
            this.lb9.TabIndex = 10;
            this.lb9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.Location = new System.Drawing.Point(4, 411);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(0, 20);
            this.lb10.TabIndex = 11;
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.Location = new System.Drawing.Point(4, 452);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(0, 20);
            this.lb11.TabIndex = 12;
            this.lb11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb12
            // 
            this.lb12.AutoSize = true;
            this.lb12.Location = new System.Drawing.Point(4, 493);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(0, 20);
            this.lb12.TabIndex = 13;
            this.lb12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(16, 113);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(161, 40);
            this.btClear.TabIndex = 14;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 613);
            this.Controls.Add(this.tabl);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.edRule);
            this.Controls.Add(this.lbRule);
            this.Controls.Add(this.btClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edRule)).EndInit();
            this.tabl.ResumeLayout(false);
            this.tabl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRule;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.NumericUpDown edRule;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TableLayoutPanel tabl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb0;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Button btClear;
    }
}

