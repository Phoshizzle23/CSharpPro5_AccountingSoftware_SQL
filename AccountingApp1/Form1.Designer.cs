namespace AccountingApp1
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
            panel1 = new Panel();
            exitBtn = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            displayBtn = new Button();
            totalText = new TextBox();
            addressText = new TextBox();
            dateText = new TextBox();
            clientNameText = new TextBox();
            clientIdText = new TextBox();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            saveBtn = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            clearBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(exitBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1442, 116);
            panel1.TabIndex = 0;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Crimson;
            exitBtn.Location = new Point(1390, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(49, 33);
            exitBtn.TabIndex = 3;
            exitBtn.Text = " X";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("AniMe Matrix - MB_EN", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(320, 26);
            label1.Name = "label1";
            label1.Size = new Size(792, 57);
            label1.TabIndex = 1;
            label1.Text = "Accounting Software";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(100, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightYellow;
            panel2.Controls.Add(clearBtn);
            panel2.Controls.Add(displayBtn);
            panel2.Controls.Add(totalText);
            panel2.Controls.Add(addressText);
            panel2.Controls.Add(dateText);
            panel2.Controls.Add(clientNameText);
            panel2.Controls.Add(clientIdText);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(addBtn);
            panel2.Controls.Add(saveBtn);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(545, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(897, 347);
            panel2.TabIndex = 1;
            // 
            // displayBtn
            // 
            displayBtn.Location = new Point(709, 37);
            displayBtn.Name = "displayBtn";
            displayBtn.Size = new Size(146, 39);
            displayBtn.TabIndex = 15;
            displayBtn.Text = "DISPLAY";
            displayBtn.UseVisualStyleBackColor = true;
            displayBtn.Click += displayBtn_Click;
            // 
            // totalText
            // 
            totalText.Location = new Point(335, 222);
            totalText.Name = "totalText";
            totalText.Size = new Size(250, 30);
            totalText.TabIndex = 14;
            // 
            // addressText
            // 
            addressText.Location = new Point(335, 177);
            addressText.Name = "addressText";
            addressText.Size = new Size(250, 30);
            addressText.TabIndex = 13;
            // 
            // dateText
            // 
            dateText.Location = new Point(335, 132);
            dateText.Name = "dateText";
            dateText.Size = new Size(250, 30);
            dateText.TabIndex = 12;
            // 
            // clientNameText
            // 
            clientNameText.Location = new Point(335, 84);
            clientNameText.Name = "clientNameText";
            clientNameText.Size = new Size(250, 30);
            clientNameText.TabIndex = 11;
            // 
            // clientIdText
            // 
            clientIdText.Location = new Point(335, 30);
            clientIdText.Name = "clientIdText";
            clientIdText.Size = new Size(250, 30);
            clientIdText.TabIndex = 10;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(709, 280);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(146, 43);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(491, 280);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(146, 43);
            updateBtn.TabIndex = 8;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(281, 280);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(146, 43);
            addBtn.TabIndex = 7;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(72, 280);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(146, 43);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("AniMe Matrix - MB_EN", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 2);
            label7.Name = "label7";
            label7.Size = new Size(152, 16);
            label7.TabIndex = 5;
            label7.Text = "Client Records";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 222);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 4;
            label6.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 177);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 3;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 132);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 2;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 84);
            label3.Name = "label3";
            label3.Size = new Size(167, 23);
            label3.TabIndex = 1;
            label3.Text = "ClientName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 32);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 0;
            label2.Text = "ClientId";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(546, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 508);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1442, 178);
            dataGridView1.TabIndex = 2;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(709, 180);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(146, 38);
            clearBtn.TabIndex = 16;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1442, 682);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("AniMe Matrix - MB_EN", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 5, 7, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private Button saveBtn;
        private TextBox totalText;
        private TextBox addressText;
        private TextBox dateText;
        private TextBox clientNameText;
        private TextBox clientIdText;
        private DataGridView dataGridView1;
        private Button exitBtn;
        private Button displayBtn;
        private Button clearBtn;
    }
}