namespace BaiTapLonSQL
{
    partial class frm_screening_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_screening_details));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.Panel();
            this.txt_idscreening = new System.Windows.Forms.TextBox();
            this.txt_id_screening = new System.Windows.Forms.Label();
            this.txt_screeningend = new System.Windows.Forms.TextBox();
            this.txt_end = new System.Windows.Forms.Label();
            this.txt_screeningstrart = new System.Windows.Forms.TextBox();
            this.txt_start = new System.Windows.Forms.Label();
            this.txt_audio_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_movies_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.txt_id.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15966F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84034F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 219);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 331);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 101);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(697, 23);
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
            this.btn_delete.Location = new System.Drawing.Point(536, 23);
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
            this.btn_update.Location = new System.Drawing.Point(372, 23);
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
            this.btn_add.Location = new System.Drawing.Point(211, 23);
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
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_id.Controls.Add(this.txt_idscreening);
            this.txt_id.Controls.Add(this.txt_id_screening);
            this.txt_id.Controls.Add(this.txt_screeningend);
            this.txt_id.Controls.Add(this.txt_end);
            this.txt_id.Controls.Add(this.txt_screeningstrart);
            this.txt_id.Controls.Add(this.txt_start);
            this.txt_id.Controls.Add(this.txt_audio_ID);
            this.txt_id.Controls.Add(this.label2);
            this.txt_id.Controls.Add(this.txt_movies_ID);
            this.txt_id.Controls.Add(this.label1);
            this.txt_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_id.Location = new System.Drawing.Point(4, 4);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(1059, 98);
            this.txt_id.TabIndex = 2;
            // 
            // txt_idscreening
            // 
            this.txt_idscreening.Enabled = false;
            this.txt_idscreening.Location = new System.Drawing.Point(106, 26);
            this.txt_idscreening.Name = "txt_idscreening";
            this.txt_idscreening.Size = new System.Drawing.Size(157, 22);
            this.txt_idscreening.TabIndex = 16;
            // 
            // txt_id_screening
            // 
            this.txt_id_screening.AutoSize = true;
            this.txt_id_screening.Location = new System.Drawing.Point(21, 28);
            this.txt_id_screening.Name = "txt_id_screening";
            this.txt_id_screening.Size = new System.Drawing.Size(53, 17);
            this.txt_id_screening.TabIndex = 4;
            this.txt_id_screening.Text = "PK_id :";
            // 
            // txt_screeningend
            // 
            this.txt_screeningend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_screeningend.Location = new System.Drawing.Point(821, 50);
            this.txt_screeningend.Margin = new System.Windows.Forms.Padding(4);
            this.txt_screeningend.Name = "txt_screeningend";
            this.txt_screeningend.Size = new System.Drawing.Size(207, 22);
            this.txt_screeningend.TabIndex = 15;
            // 
            // txt_end
            // 
            this.txt_end.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_end.AutoSize = true;
            this.txt_end.Location = new System.Drawing.Point(699, 53);
            this.txt_end.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(105, 17);
            this.txt_end.TabIndex = 14;
            this.txt_end.Text = "Screening End:";
            // 
            // txt_screeningstrart
            // 
            this.txt_screeningstrart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_screeningstrart.Location = new System.Drawing.Point(821, 20);
            this.txt_screeningstrart.Margin = new System.Windows.Forms.Padding(4);
            this.txt_screeningstrart.Name = "txt_screeningstrart";
            this.txt_screeningstrart.Size = new System.Drawing.Size(207, 22);
            this.txt_screeningstrart.TabIndex = 13;
            // 
            // txt_start
            // 
            this.txt_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_start.AutoSize = true;
            this.txt_start.Location = new System.Drawing.Point(694, 26);
            this.txt_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(110, 17);
            this.txt_start.TabIndex = 12;
            this.txt_start.Text = "Screening Start:";
            // 
            // txt_audio_ID
            // 
            this.txt_audio_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_audio_ID.Location = new System.Drawing.Point(445, 53);
            this.txt_audio_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_audio_ID.Name = "txt_audio_ID";
            this.txt_audio_ID.Size = new System.Drawing.Size(207, 22);
            this.txt_audio_ID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Audiotoriums_ID:";
            // 
            // txt_movies_ID
            // 
            this.txt_movies_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_movies_ID.Location = new System.Drawing.Point(445, 23);
            this.txt_movies_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_movies_ID.Name = "txt_movies_ID";
            this.txt_movies_ID.Size = new System.Drawing.Size(207, 22);
            this.txt_movies_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movies_ID:";
            // 
            // frm_screening_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_screening_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screening - Details";
            this.Load += new System.EventHandler(this.Frm_screening_details_Load);
            this.DoubleClick += new System.EventHandler(this.Frm_screening_details_DoubleClick);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.txt_id.ResumeLayout(false);
            this.txt_id.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel txt_id;
        private System.Windows.Forms.TextBox txt_screeningend;
        private System.Windows.Forms.Label txt_end;
        private System.Windows.Forms.TextBox txt_screeningstrart;
        private System.Windows.Forms.Label txt_start;
        private System.Windows.Forms.TextBox txt_audio_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_movies_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idscreening;
        private System.Windows.Forms.Label txt_id_screening;
    }
}