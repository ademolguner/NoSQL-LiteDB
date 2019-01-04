namespace LiteDbExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dgpersonellist = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btncancelselected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgpersonellist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(124, 28);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(243, 20);
            this.txtfirstname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(124, 61);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(243, 20);
            this.txtlastname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Age";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(124, 92);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(73, 20);
            this.txtage.TabIndex = 1;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(265, 210);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(102, 52);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dgpersonellist
            // 
            this.dgpersonellist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgpersonellist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgpersonellist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgpersonellist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpersonellist.Location = new System.Drawing.Point(406, 28);
            this.dgpersonellist.MultiSelect = false;
            this.dgpersonellist.Name = "dgpersonellist";
            this.dgpersonellist.ReadOnly = true;
            this.dgpersonellist.Size = new System.Drawing.Size(382, 324);
            this.dgpersonellist.TabIndex = 4;
            this.dgpersonellist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgpersonellist_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(402, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kayıtlı Personeller";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(265, 268);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(102, 47);
            this.btnguncelle.TabIndex = 5;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Visible = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(157, 268);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(102, 47);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "SIL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Visible = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btncancelselected
            // 
            this.btncancelselected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncancelselected.ForeColor = System.Drawing.Color.Red;
            this.btncancelselected.Location = new System.Drawing.Point(157, 321);
            this.btncancelselected.Name = "btncancelselected";
            this.btncancelselected.Size = new System.Drawing.Size(210, 30);
            this.btncancelselected.TabIndex = 7;
            this.btncancelselected.Text = "X Seçimi İptal Et";
            this.btncancelselected.UseVisualStyleBackColor = true;
            this.btncancelselected.Visible = false;
            this.btncancelselected.Click += new System.EventHandler(this.btncancelselected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.btncancelselected);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.dgpersonellist);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LiteDB Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgpersonellist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.DataGridView dgpersonellist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btncancelselected;
    }
}

