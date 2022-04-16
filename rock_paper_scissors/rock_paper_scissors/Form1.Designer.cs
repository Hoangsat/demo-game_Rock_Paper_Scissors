namespace rock_paper_scissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.user_panel_rock = new System.Windows.Forms.Panel();
            this.picture_rock = new System.Windows.Forms.PictureBox();
            this.user_panel_scissors = new System.Windows.Forms.Panel();
            this.picture_scissors = new System.Windows.Forms.PictureBox();
            this.user_panel_paper = new System.Windows.Forms.Panel();
            this.picture_paper = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picture_rock_comp = new System.Windows.Forms.PictureBox();
            this.picture_scissors_comp = new System.Windows.Forms.PictureBox();
            this.picture_paper_comp = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.user_panel_rock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rock)).BeginInit();
            this.user_panel_scissors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_scissors)).BeginInit();
            this.user_panel_paper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_paper)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rock_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_scissors_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_paper_comp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(32, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 126);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 126);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.user_panel_rock);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 126);
            this.panel3.TabIndex = 1;
            // 
            // user_panel_rock
            // 
            this.user_panel_rock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_panel_rock.Controls.Add(this.picture_rock);
            this.user_panel_rock.Location = new System.Drawing.Point(-1, -1);
            this.user_panel_rock.Name = "user_panel_rock";
            this.user_panel_rock.Size = new System.Drawing.Size(187, 126);
            this.user_panel_rock.TabIndex = 2;
            this.user_panel_rock.Tag = "";
            this.user_panel_rock.MouseEnter += new System.EventHandler(this.user_panel_rock_MouseEnter);
            // 
            // picture_rock
            // 
            this.picture_rock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_rock.Image = global::rock_paper_scissors.Properties.Resources.user_rock;
            this.picture_rock.Location = new System.Drawing.Point(0, 0);
            this.picture_rock.Name = "picture_rock";
            this.picture_rock.Size = new System.Drawing.Size(185, 124);
            this.picture_rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_rock.TabIndex = 5;
            this.picture_rock.TabStop = false;
            this.picture_rock.Visible = false;
            // 
            // user_panel_scissors
            // 
            this.user_panel_scissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_panel_scissors.Controls.Add(this.picture_scissors);
            this.user_panel_scissors.Location = new System.Drawing.Point(258, 24);
            this.user_panel_scissors.Name = "user_panel_scissors";
            this.user_panel_scissors.Size = new System.Drawing.Size(187, 126);
            this.user_panel_scissors.TabIndex = 2;
            this.user_panel_scissors.Tag = "";
            this.user_panel_scissors.MouseEnter += new System.EventHandler(this.user_panel_scissors_MouseEnter);
            // 
            // picture_scissors
            // 
            this.picture_scissors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_scissors.Image = global::rock_paper_scissors.Properties.Resources.user_scissos;
            this.picture_scissors.Location = new System.Drawing.Point(0, 0);
            this.picture_scissors.Name = "picture_scissors";
            this.picture_scissors.Size = new System.Drawing.Size(185, 124);
            this.picture_scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_scissors.TabIndex = 6;
            this.picture_scissors.TabStop = false;
            this.picture_scissors.Visible = false;
            // 
            // user_panel_paper
            // 
            this.user_panel_paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_panel_paper.Controls.Add(this.picture_paper);
            this.user_panel_paper.Location = new System.Drawing.Point(488, 24);
            this.user_panel_paper.Name = "user_panel_paper";
            this.user_panel_paper.Size = new System.Drawing.Size(187, 126);
            this.user_panel_paper.TabIndex = 3;
            this.user_panel_paper.Tag = "";
            this.user_panel_paper.MouseEnter += new System.EventHandler(this.user_panel_paper_MouseEnter);
            // 
            // picture_paper
            // 
            this.picture_paper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_paper.Image = global::rock_paper_scissors.Properties.Resources.user_paper;
            this.picture_paper.Location = new System.Drawing.Point(0, 0);
            this.picture_paper.Name = "picture_paper";
            this.picture_paper.Size = new System.Drawing.Size(185, 124);
            this.picture_paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_paper.TabIndex = 7;
            this.picture_paper.TabStop = false;
            this.picture_paper.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.picture_rock_comp);
            this.panel5.Controls.Add(this.picture_scissors_comp);
            this.panel5.Controls.Add(this.picture_paper_comp);
            this.panel5.Location = new System.Drawing.Point(909, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(187, 126);
            this.panel5.TabIndex = 4;
            // 
            // picture_rock_comp
            // 
            this.picture_rock_comp.Image = global::rock_paper_scissors.Properties.Resources.rock;
            this.picture_rock_comp.Location = new System.Drawing.Point(0, 0);
            this.picture_rock_comp.Name = "picture_rock_comp";
            this.picture_rock_comp.Size = new System.Drawing.Size(187, 126);
            this.picture_rock_comp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_rock_comp.TabIndex = 5;
            this.picture_rock_comp.TabStop = false;
            this.picture_rock_comp.Visible = false;
            // 
            // picture_scissors_comp
            // 
            this.picture_scissors_comp.Image = global::rock_paper_scissors.Properties.Resources.scissors;
            this.picture_scissors_comp.Location = new System.Drawing.Point(0, 0);
            this.picture_scissors_comp.Name = "picture_scissors_comp";
            this.picture_scissors_comp.Size = new System.Drawing.Size(187, 126);
            this.picture_scissors_comp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_scissors_comp.TabIndex = 6;
            this.picture_scissors_comp.TabStop = false;
            this.picture_scissors_comp.Visible = false;
            // 
            // picture_paper_comp
            // 
            this.picture_paper_comp.Image = global::rock_paper_scissors.Properties.Resources.paper;
            this.picture_paper_comp.Location = new System.Drawing.Point(0, 0);
            this.picture_paper_comp.Name = "picture_paper_comp";
            this.picture_paper_comp.Size = new System.Drawing.Size(187, 126);
            this.picture_paper_comp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_paper_comp.TabIndex = 7;
            this.picture_paper_comp.TabStop = false;
            this.picture_paper_comp.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 244);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.user_panel_scissors);
            this.Controls.Add(this.user_panel_paper);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock paper scissors";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.user_panel_rock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_rock)).EndInit();
            this.user_panel_scissors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_scissors)).EndInit();
            this.user_panel_paper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_paper)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_rock_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_scissors_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_paper_comp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel user_panel_rock;
        private System.Windows.Forms.Panel user_panel_scissors;
        private System.Windows.Forms.Panel user_panel_paper;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox picture_rock;
        private System.Windows.Forms.PictureBox picture_scissors;
        private System.Windows.Forms.PictureBox picture_paper;
        private System.Windows.Forms.PictureBox picture_rock_comp;
        private System.Windows.Forms.PictureBox picture_scissors_comp;
        private System.Windows.Forms.PictureBox picture_paper_comp;
    }
}

