namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Commands = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Ac = new System.Windows.Forms.Label();
            this.lbl_Mar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Mbr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_IR = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Pc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_OutputReg = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_InReg = new System.Windows.Forms.TextBox();
            this.lbl_Exp = new System.Windows.Forms.Label();
            this.dg_Memory = new System.Windows.Forms.DataGridView();
            this.dg_Tag = new System.Windows.Forms.DataGridView();
            this.txt_RndStart = new System.Windows.Forms.TextBox();
            this.txt_RndEnd = new System.Windows.Forms.TextBox();
            this.btn_CreateRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Memory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Tag)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Commands
            // 
            this.txt_Commands.Location = new System.Drawing.Point(12, 31);
            this.txt_Commands.Multiline = true;
            this.txt_Commands.Name = "txt_Commands";
            this.txt_Commands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Commands.Size = new System.Drawing.Size(629, 341);
            this.txt_Commands.TabIndex = 0;
            this.txt_Commands.TextChanged += new System.EventHandler(this.txt_Commands_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(765, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bellek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Etiketler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "AC            :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Ac
            // 
            this.lbl_Ac.AutoSize = true;
            this.lbl_Ac.Location = new System.Drawing.Point(85, 429);
            this.lbl_Ac.Name = "lbl_Ac";
            this.lbl_Ac.Size = new System.Drawing.Size(31, 13);
            this.lbl_Ac.TabIndex = 6;
            this.lbl_Ac.Text = "0000";
            this.lbl_Ac.Click += new System.EventHandler(this.lbl_Ac_Click);
            // 
            // lbl_Mar
            // 
            this.lbl_Mar.AutoSize = true;
            this.lbl_Mar.Location = new System.Drawing.Point(85, 454);
            this.lbl_Mar.Name = "lbl_Mar";
            this.lbl_Mar.Size = new System.Drawing.Size(31, 13);
            this.lbl_Mar.TabIndex = 8;
            this.lbl_Mar.Text = "0000";
            this.lbl_Mar.Click += new System.EventHandler(this.lbl_Mar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "MAR         :";
            // 
            // lbl_Mbr
            // 
            this.lbl_Mbr.AutoSize = true;
            this.lbl_Mbr.Location = new System.Drawing.Point(85, 480);
            this.lbl_Mbr.Name = "lbl_Mbr";
            this.lbl_Mbr.Size = new System.Drawing.Size(31, 13);
            this.lbl_Mbr.TabIndex = 10;
            this.lbl_Mbr.Text = "0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "MBR         :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbl_IR
            // 
            this.lbl_IR.AutoSize = true;
            this.lbl_IR.Location = new System.Drawing.Point(85, 505);
            this.lbl_IR.Name = "lbl_IR";
            this.lbl_IR.Size = new System.Drawing.Size(31, 13);
            this.lbl_IR.TabIndex = 12;
            this.lbl_IR.Text = "0000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(9, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "IR            :";
            // 
            // lbl_Pc
            // 
            this.lbl_Pc.AutoSize = true;
            this.lbl_Pc.Location = new System.Drawing.Point(85, 533);
            this.lbl_Pc.Name = "lbl_Pc";
            this.lbl_Pc.Size = new System.Drawing.Size(31, 13);
            this.lbl_Pc.TabIndex = 14;
            this.lbl_Pc.Text = "0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(9, 533);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "PC            :";
            // 
            // lbl_OutputReg
            // 
            this.lbl_OutputReg.AutoSize = true;
            this.lbl_OutputReg.Location = new System.Drawing.Point(85, 556);
            this.lbl_OutputReg.Name = "lbl_OutputReg";
            this.lbl_OutputReg.Size = new System.Drawing.Size(31, 13);
            this.lbl_OutputReg.TabIndex = 16;
            this.lbl_OutputReg.Text = "0000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(9, 556);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "OutReg     :";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(210, 387);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.Text = "Temizle";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(312, 386);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(117, 23);
            this.btn_Load.TabIndex = 18;
            this.btn_Load.Text = "Programı Yükle";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(450, 386);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(117, 23);
            this.btn_run.TabIndex = 19;
            this.btn_run.Text = "Çalıştır";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(295, 556);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "InReg  :";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txt_InReg
            // 
            this.txt_InReg.Location = new System.Drawing.Point(352, 553);
            this.txt_InReg.Name = "txt_InReg";
            this.txt_InReg.Size = new System.Drawing.Size(100, 20);
            this.txt_InReg.TabIndex = 21;
            this.txt_InReg.TextChanged += new System.EventHandler(this.txt_InReg_TextChanged);
            // 
            // lbl_Exp
            // 
            this.lbl_Exp.AutoSize = true;
            this.lbl_Exp.Location = new System.Drawing.Point(12, 9);
            this.lbl_Exp.Name = "lbl_Exp";
            this.lbl_Exp.Size = new System.Drawing.Size(0, 13);
            this.lbl_Exp.TabIndex = 22;
            // 
            // dg_Memory
            // 
            this.dg_Memory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Memory.Location = new System.Drawing.Point(673, 31);
            this.dg_Memory.Name = "dg_Memory";
            this.dg_Memory.Size = new System.Drawing.Size(240, 320);
            this.dg_Memory.TabIndex = 23;
            // 
            // dg_Tag
            // 
            this.dg_Tag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Tag.Location = new System.Drawing.Point(673, 386);
            this.dg_Tag.Name = "dg_Tag";
            this.dg_Tag.Size = new System.Drawing.Size(240, 205);
            this.dg_Tag.TabIndex = 24;
            // 
            // txt_RndStart
            // 
            this.txt_RndStart.Location = new System.Drawing.Point(194, 447);
            this.txt_RndStart.Name = "txt_RndStart";
            this.txt_RndStart.Size = new System.Drawing.Size(100, 20);
            this.txt_RndStart.TabIndex = 25;
            this.txt_RndStart.TextChanged += new System.EventHandler(this.txt_RndStart_TextChanged);
            // 
            // txt_RndEnd
            // 
            this.txt_RndEnd.Location = new System.Drawing.Point(312, 447);
            this.txt_RndEnd.Name = "txt_RndEnd";
            this.txt_RndEnd.Size = new System.Drawing.Size(100, 20);
            this.txt_RndEnd.TabIndex = 26;
            // 
            // btn_CreateRandom
            // 
            this.btn_CreateRandom.Location = new System.Drawing.Point(428, 447);
            this.btn_CreateRandom.Name = "btn_CreateRandom";
            this.btn_CreateRandom.Size = new System.Drawing.Size(122, 20);
            this.btn_CreateRandom.TabIndex = 27;
            this.btn_CreateRandom.Text = "Random Sayı Oluştur";
            this.btn_CreateRandom.UseVisualStyleBackColor = true;
            this.btn_CreateRandom.Click += new System.EventHandler(this.btn_CreateRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 603);
            this.Controls.Add(this.btn_CreateRandom);
            this.Controls.Add(this.txt_RndEnd);
            this.Controls.Add(this.txt_RndStart);
            this.Controls.Add(this.dg_Tag);
            this.Controls.Add(this.dg_Memory);
            this.Controls.Add(this.lbl_Exp);
            this.Controls.Add(this.txt_InReg);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_OutputReg);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_Pc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_IR);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_Mbr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Mar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Ac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Commands);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Memory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Tag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Commands;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Ac;
        private System.Windows.Forms.Label lbl_Mar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Mbr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_IR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Pc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_OutputReg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_InReg;
        private System.Windows.Forms.Label lbl_Exp;
        private System.Windows.Forms.DataGridView dg_Memory;
        private System.Windows.Forms.DataGridView dg_Tag;
        private System.Windows.Forms.TextBox txt_RndStart;
        private System.Windows.Forms.TextBox txt_RndEnd;
        private System.Windows.Forms.Button btn_CreateRandom;
    }
}

