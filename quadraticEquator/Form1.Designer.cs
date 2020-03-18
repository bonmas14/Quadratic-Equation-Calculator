namespace quadraticEquator
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.FornInterface4 = new System.Windows.Forms.Label();
            this.FormInterface3 = new System.Windows.Forms.Label();
            this.FormInterface2 = new System.Windows.Forms.Label();
            this.FormInterface1 = new System.Windows.Forms.Label();
            this.nCvar = new System.Windows.Forms.NumericUpDown();
            this.nBvar = new System.Windows.Forms.NumericUpDown();
            this.nAvar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.FornInterface6 = new System.Windows.Forms.Label();
            this.FormInterface5 = new System.Windows.Forms.Label();
            this.nMinVar = new System.Windows.Forms.NumericUpDown();
            this.nMaxVar = new System.Windows.Forms.NumericUpDown();
            this.lOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lUserError = new System.Windows.Forms.Label();
            this.FormInterface7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinVar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxVar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.lUserError);
            this.splitContainer1.Panel2.Controls.Add(this.FormInterface7);
            this.splitContainer1.Size = new System.Drawing.Size(484, 362);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer2.Panel2.Controls.Add(this.lOutput);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(302, 362);
            this.splitContainer2.SplitterDistance = 150;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.FornInterface4);
            this.splitContainer3.Panel1.Controls.Add(this.FormInterface3);
            this.splitContainer3.Panel1.Controls.Add(this.FormInterface2);
            this.splitContainer3.Panel1.Controls.Add(this.FormInterface1);
            this.splitContainer3.Panel1.Controls.Add(this.nCvar);
            this.splitContainer3.Panel1.Controls.Add(this.nBvar);
            this.splitContainer3.Panel1.Controls.Add(this.nAvar);
            this.splitContainer3.Panel1MinSize = 24;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label2);
            this.splitContainer3.Panel2.Controls.Add(this.FornInterface6);
            this.splitContainer3.Panel2.Controls.Add(this.FormInterface5);
            this.splitContainer3.Panel2.Controls.Add(this.nMinVar);
            this.splitContainer3.Panel2.Controls.Add(this.nMaxVar);
            this.splitContainer3.Size = new System.Drawing.Size(302, 150);
            this.splitContainer3.SplitterDistance = 75;
            this.splitContainer3.TabIndex = 0;
            // 
            // FornInterface4
            // 
            this.FornInterface4.AutoSize = true;
            this.FornInterface4.Location = new System.Drawing.Point(174, 47);
            this.FornInterface4.Name = "FornInterface4";
            this.FornInterface4.Size = new System.Drawing.Size(17, 13);
            this.FornInterface4.TabIndex = 6;
            this.FornInterface4.Text = "C:";
            // 
            // FormInterface3
            // 
            this.FormInterface3.AutoSize = true;
            this.FormInterface3.Location = new System.Drawing.Point(89, 21);
            this.FormInterface3.Name = "FormInterface3";
            this.FormInterface3.Size = new System.Drawing.Size(17, 13);
            this.FormInterface3.TabIndex = 5;
            this.FormInterface3.Text = "B:";
            // 
            // FormInterface2
            // 
            this.FormInterface2.AutoSize = true;
            this.FormInterface2.Location = new System.Drawing.Point(3, 47);
            this.FormInterface2.Name = "FormInterface2";
            this.FormInterface2.Size = new System.Drawing.Size(17, 13);
            this.FormInterface2.TabIndex = 4;
            this.FormInterface2.Text = "A:";
            // 
            // FormInterface1
            // 
            this.FormInterface1.AutoSize = true;
            this.FormInterface1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormInterface1.Location = new System.Drawing.Point(0, 4);
            this.FormInterface1.Name = "FormInterface1";
            this.FormInterface1.Size = new System.Drawing.Size(58, 13);
            this.FormInterface1.TabIndex = 3;
            this.FormInterface1.Text = "Значения:";
            // 
            // nCvar
            // 
            this.nCvar.Location = new System.Drawing.Point(197, 45);
            this.nCvar.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nCvar.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.nCvar.Name = "nCvar";
            this.nCvar.Size = new System.Drawing.Size(100, 20);
            this.nCvar.TabIndex = 2;
            this.nCvar.ValueChanged += new System.EventHandler(this.nCvar_ValueChanged);
            // 
            // nBvar
            // 
            this.nBvar.Location = new System.Drawing.Point(109, 19);
            this.nBvar.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nBvar.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.nBvar.Name = "nBvar";
            this.nBvar.Size = new System.Drawing.Size(100, 20);
            this.nBvar.TabIndex = 1;
            this.nBvar.ValueChanged += new System.EventHandler(this.nBvar_ValueChanged);
            // 
            // nAvar
            // 
            this.nAvar.Location = new System.Drawing.Point(24, 45);
            this.nAvar.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nAvar.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.nAvar.Name = "nAvar";
            this.nAvar.Size = new System.Drawing.Size(100, 20);
            this.nAvar.TabIndex = 0;
            this.nAvar.ValueChanged += new System.EventHandler(this.nAvar_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Входные значения (A, B, C)";
            // 
            // FornInterface6
            // 
            this.FornInterface6.AutoSize = true;
            this.FornInterface6.Location = new System.Drawing.Point(130, 48);
            this.FornInterface6.Name = "FornInterface6";
            this.FornInterface6.Size = new System.Drawing.Size(128, 13);
            this.FornInterface6.TabIndex = 3;
            this.FornInterface6.Text = "Минимальное значение";
            // 
            // FormInterface5
            // 
            this.FormInterface5.AutoSize = true;
            this.FormInterface5.Location = new System.Drawing.Point(130, 6);
            this.FormInterface5.Name = "FormInterface5";
            this.FormInterface5.Size = new System.Drawing.Size(134, 13);
            this.FormInterface5.TabIndex = 2;
            this.FormInterface5.Text = "Максимальное значение";
            // 
            // nMinVar
            // 
            this.nMinVar.Location = new System.Drawing.Point(4, 46);
            this.nMinVar.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nMinVar.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nMinVar.Name = "nMinVar";
            this.nMinVar.Size = new System.Drawing.Size(120, 20);
            this.nMinVar.TabIndex = 1;
            this.nMinVar.Value = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.nMinVar.ValueChanged += new System.EventHandler(this.nMinVar_ValueChanged);
            // 
            // nMaxVar
            // 
            this.nMaxVar.Location = new System.Drawing.Point(4, 4);
            this.nMaxVar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nMaxVar.Name = "nMaxVar";
            this.nMaxVar.Size = new System.Drawing.Size(120, 20);
            this.nMaxVar.TabIndex = 0;
            this.nMaxVar.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nMaxVar.ValueChanged += new System.EventHandler(this.nMaxVar_ValueChanged);
            // 
            // lOutput
            // 
            this.lOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOutput.Location = new System.Drawing.Point(2, 0);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(298, 194);
            this.lOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(1, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creator - bonmas14@gmail.com";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Очистить лог";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lUserError
            // 
            this.lUserError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUserError.Location = new System.Drawing.Point(3, 26);
            this.lUserError.Name = "lUserError";
            this.lUserError.Size = new System.Drawing.Size(170, 293);
            this.lUserError.TabIndex = 1;
            // 
            // FormInterface7
            // 
            this.FormInterface7.AutoSize = true;
            this.FormInterface7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormInterface7.Location = new System.Drawing.Point(11, 4);
            this.FormInterface7.Name = "FormInterface7";
            this.FormInterface7.Size = new System.Drawing.Size(154, 13);
            this.FormInterface7.TabIndex = 0;
            this.FormInterface7.Text = "Ошибки будут появлятся тут.";
            // 
            // MainForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Equation Calculator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nCvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinVar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxVar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.NumericUpDown nCvar;
        private System.Windows.Forms.NumericUpDown nBvar;
        private System.Windows.Forms.NumericUpDown nAvar;
        private System.Windows.Forms.Label FornInterface6;
        private System.Windows.Forms.Label FormInterface5;
        private System.Windows.Forms.NumericUpDown nMinVar;
        private System.Windows.Forms.NumericUpDown nMaxVar;
        private System.Windows.Forms.Label FornInterface4;
        private System.Windows.Forms.Label FormInterface3;
        private System.Windows.Forms.Label FormInterface2;
        private System.Windows.Forms.Label FormInterface1;
        private System.Windows.Forms.Label FormInterface7;
        private System.Windows.Forms.Label lUserError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

