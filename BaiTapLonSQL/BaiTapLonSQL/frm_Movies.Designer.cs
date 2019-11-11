namespace BaiTapLonSQL
{
    partial class frm_Movies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Movies));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.Panel();
            this.date_rele = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_statusmovie = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_descriptmovie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_lengthmovie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ratedmovie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_genremovie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_languagemovie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_directormovie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_avtmovie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_namemovie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idmovie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cast = new System.Windows.Forms.Label();
            this.txt_castmovie = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.txt_id.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 211);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 78);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(697, 12);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(153, 53);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(536, 12);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(153, 53);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.Location = new System.Drawing.Point(372, 12);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(153, 53);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(211, 12);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(153, 53);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 297);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 253);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_id.Controls.Add(this.txt_castmovie);
            this.txt_id.Controls.Add(this.Cast);
            this.txt_id.Controls.Add(this.date_rele);
            this.txt_id.Controls.Add(this.label11);
            this.txt_id.Controls.Add(this.txt_statusmovie);
            this.txt_id.Controls.Add(this.label9);
            this.txt_id.Controls.Add(this.txt_descriptmovie);
            this.txt_id.Controls.Add(this.label10);
            this.txt_id.Controls.Add(this.txt_lengthmovie);
            this.txt_id.Controls.Add(this.label7);
            this.txt_id.Controls.Add(this.txt_ratedmovie);
            this.txt_id.Controls.Add(this.label8);
            this.txt_id.Controls.Add(this.txt_genremovie);
            this.txt_id.Controls.Add(this.label5);
            this.txt_id.Controls.Add(this.txt_languagemovie);
            this.txt_id.Controls.Add(this.label6);
            this.txt_id.Controls.Add(this.txt_directormovie);
            this.txt_id.Controls.Add(this.label3);
            this.txt_id.Controls.Add(this.txt_avtmovie);
            this.txt_id.Controls.Add(this.label4);
            this.txt_id.Controls.Add(this.txt_namemovie);
            this.txt_id.Controls.Add(this.label2);
            this.txt_id.Controls.Add(this.txt_idmovie);
            this.txt_id.Controls.Add(this.label1);
            this.txt_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_id.Location = new System.Drawing.Point(4, 4);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(1059, 199);
            this.txt_id.TabIndex = 2;
            this.txt_id.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // date_rele
            // 
            this.date_rele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_rele.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_rele.Location = new System.Drawing.Point(808, 108);
            this.date_rele.Margin = new System.Windows.Forms.Padding(4);
            this.date_rele.Name = "date_rele";
            this.date_rele.Size = new System.Drawing.Size(169, 22);
            this.date_rele.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(693, 111);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Released_date: ";
            // 
            // txt_statusmovie
            // 
            this.txt_statusmovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_statusmovie.Location = new System.Drawing.Point(439, 139);
            this.txt_statusmovie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_statusmovie.Name = "txt_statusmovie";
            this.txt_statusmovie.Size = new System.Drawing.Size(221, 22);
            this.txt_statusmovie.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 143);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Status:";
            // 
            // txt_descriptmovie
            // 
            this.txt_descriptmovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_descriptmovie.Location = new System.Drawing.Point(439, 107);
            this.txt_descriptmovie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descriptmovie.Name = "txt_descriptmovie";
            this.txt_descriptmovie.Size = new System.Drawing.Size(221, 22);
            this.txt_descriptmovie.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Description:";
            // 
            // txt_lengthmovie
            // 
            this.txt_lengthmovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_lengthmovie.Location = new System.Drawing.Point(132, 139);
            this.txt_lengthmovie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lengthmovie.Name = "txt_lengthmovie";
            this.txt_lengthmovie.Size = new System.Drawing.Size(207, 22);
            this.txt_lengthmovie.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Length:";
            // 
            // txt_ratedmovie
            // 
            this.txt_ratedmovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ratedmovie.Location = new System.Drawing.Point(132, 107);
            this.txt_ratedmovie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ratedmovie.Name = "txt_ratedmovie";
            this.txt_ratedmovie.Size = new System.Drawing.Size(207, 22);
            this.txt_ratedmovie.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Rated:";
            // 
            // txt_genremovie
            // 
            this.txt_genremovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_genremovie.Location = new System.Drawing.Point(808, 75);
            this.txt_genremovie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_genremovie.Name = "txt_genremovie";
            this.txt_genremovie.Size = new System.Drawing.Size(169, 22);
            this.txt_genremovie.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(748, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Genre:";
            // 
            // txt_languagemovie
            // 
            this.txt_languagemovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_languagemovie.Location = new System.Drawing.Point(808, 43);
            this.txt_languagemovie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_languagemovie.Name = "txt_languagemovie";
            this.txt_languagemovie.Size = new System.Drawing.Size(169, 22);
            this.txt_languagemovie.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(723, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Language:";
            // 
            // txt_directormovie
            // 
            this.txt_directormovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_directormovie.Location = new System.Drawing.Point(439, 75);
            this.txt_directormovie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_directormovie.Name = "txt_directormovie";
            this.txt_directormovie.Size = new System.Drawing.Size(221, 22);
            this.txt_directormovie.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Director:";
            // 
            // txt_avtmovie
            // 
            this.txt_avtmovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_avtmovie.Location = new System.Drawing.Point(439, 43);
            this.txt_avtmovie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_avtmovie.Name = "txt_avtmovie";
            this.txt_avtmovie.Size = new System.Drawing.Size(221, 22);
            this.txt_avtmovie.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ava_Url:";
            // 
            // txt_namemovie
            // 
            this.txt_namemovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_namemovie.Location = new System.Drawing.Point(132, 75);
            this.txt_namemovie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_namemovie.Name = "txt_namemovie";
            this.txt_namemovie.Size = new System.Drawing.Size(207, 22);
            this.txt_namemovie.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txt_idmovie
            // 
            this.txt_idmovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_idmovie.Enabled = false;
            this.txt_idmovie.Location = new System.Drawing.Point(132, 43);
            this.txt_idmovie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idmovie.Name = "txt_idmovie";
            this.txt_idmovie.Size = new System.Drawing.Size(207, 22);
            this.txt_idmovie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_id, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.58823F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Cast
            // 
            this.Cast.AutoSize = true;
            this.Cast.Location = new System.Drawing.Point(759, 143);
            this.Cast.Name = "Cast";
            this.Cast.Size = new System.Drawing.Size(40, 17);
            this.Cast.TabIndex = 22;
            this.Cast.Text = "Cast:";
            // 
            // txt_castmovie
            // 
            this.txt_castmovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_castmovie.Location = new System.Drawing.Point(808, 144);
            this.txt_castmovie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_castmovie.Name = "txt_castmovie";
            this.txt_castmovie.Size = new System.Drawing.Size(169, 22);
            this.txt_castmovie.TabIndex = 23;
            // 
            // frm_Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Movies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies Manager";
            this.Load += new System.EventHandler(this.Frm_Movies_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.txt_id.ResumeLayout(false);
            this.txt_id.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel txt_id;
        private System.Windows.Forms.DateTimePicker date_rele;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_statusmovie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_descriptmovie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_lengthmovie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ratedmovie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_genremovie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_languagemovie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_directormovie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_avtmovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_namemovie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idmovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_castmovie;
        private System.Windows.Forms.Label Cast;
    }
}