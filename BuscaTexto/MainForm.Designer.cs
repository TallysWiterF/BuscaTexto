namespace BuscaTexto {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.texto = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.Sair = new System.Windows.Forms.Button();
            this.Abrir = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.Arquivo = new System.Windows.Forms.Button();
            this.panelDropDown2 = new System.Windows.Forms.Panel();
            this.Boyer_Moore = new System.Windows.Forms.Button();
            this.KMp = new System.Windows.Forms.Button();
            this.Rabin_Karp = new System.Windows.Forms.Button();
            this.Força_Bruta = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.panelDropDown3 = new System.Windows.Forms.Panel();
            this.Sobre = new System.Windows.Forms.Button();
            this.Ajuda = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.panelDropDown2.SuspendLayout();
            this.panelDropDown3.SuspendLayout();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.texto.ForeColor = System.Drawing.SystemColors.Window;
            this.texto.Location = new System.Drawing.Point(0, 63);
            this.texto.Name = "texto";
            this.texto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.texto.Size = new System.Drawing.Size(761, 578);
            this.texto.TabIndex = 1;
            this.texto.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Controls.Add(this.panelDropDown);
            this.flowLayoutPanel1.Controls.Add(this.panelDropDown2);
            this.flowLayoutPanel1.Controls.Add(this.panelDropDown3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(758, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 578);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.Sair);
            this.panelDropDown.Controls.Add(this.Abrir);
            this.panelDropDown.Controls.Add(this.Novo);
            this.panelDropDown.Controls.Add(this.Arquivo);
            this.panelDropDown.Location = new System.Drawing.Point(3, 3);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(209, 192);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(209, 66);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(209, 66);
            this.panelDropDown.TabIndex = 3;
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sair.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sair.FlatAppearance.BorderSize = 0;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.ForeColor = System.Drawing.Color.White;
            this.Sair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Sair.Location = new System.Drawing.Point(0, 148);
            this.Sair.Name = "Sair";
            this.Sair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sair.Size = new System.Drawing.Size(209, 41);
            this.Sair.TabIndex = 7;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Abrir
            // 
            this.Abrir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Abrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Abrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.Abrir.FlatAppearance.BorderSize = 0;
            this.Abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Abrir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abrir.ForeColor = System.Drawing.Color.White;
            this.Abrir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Abrir.Location = new System.Drawing.Point(0, 107);
            this.Abrir.Name = "Abrir";
            this.Abrir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Abrir.Size = new System.Drawing.Size(209, 41);
            this.Abrir.TabIndex = 6;
            this.Abrir.Text = "Abrir";
            this.Abrir.UseVisualStyleBackColor = false;
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Novo
            // 
            this.Novo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Novo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Novo.FlatAppearance.BorderSize = 0;
            this.Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Novo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Novo.ForeColor = System.Drawing.Color.White;
            this.Novo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Novo.Location = new System.Drawing.Point(0, 66);
            this.Novo.Name = "Novo";
            this.Novo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Novo.Size = new System.Drawing.Size(209, 41);
            this.Novo.TabIndex = 5;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = false;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Arquivo
            // 
            this.Arquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Arquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arquivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Arquivo.FlatAppearance.BorderSize = 0;
            this.Arquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arquivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arquivo.ForeColor = System.Drawing.Color.White;
            this.Arquivo.Image = global::BuscaTexto.Properties.Resources.Expand_Arrow_20px;
            this.Arquivo.Location = new System.Drawing.Point(0, 0);
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Arquivo.Size = new System.Drawing.Size(209, 66);
            this.Arquivo.TabIndex = 4;
            this.Arquivo.Text = "Arquivo";
            this.Arquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Arquivo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Arquivo.UseVisualStyleBackColor = false;
            this.Arquivo.Click += new System.EventHandler(this.Arquivo_Click);
            // 
            // panelDropDown2
            // 
            this.panelDropDown2.Controls.Add(this.Boyer_Moore);
            this.panelDropDown2.Controls.Add(this.KMp);
            this.panelDropDown2.Controls.Add(this.Rabin_Karp);
            this.panelDropDown2.Controls.Add(this.Força_Bruta);
            this.panelDropDown2.Controls.Add(this.Pesquisar);
            this.panelDropDown2.Location = new System.Drawing.Point(3, 75);
            this.panelDropDown2.MaximumSize = new System.Drawing.Size(209, 240);
            this.panelDropDown2.MinimumSize = new System.Drawing.Size(209, 66);
            this.panelDropDown2.Name = "panelDropDown2";
            this.panelDropDown2.Size = new System.Drawing.Size(209, 66);
            this.panelDropDown2.TabIndex = 3;
            // 
            // Boyer_Moore
            // 
            this.Boyer_Moore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Boyer_Moore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boyer_Moore.Dock = System.Windows.Forms.DockStyle.Top;
            this.Boyer_Moore.FlatAppearance.BorderSize = 0;
            this.Boyer_Moore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boyer_Moore.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Boyer_Moore.ForeColor = System.Drawing.Color.White;
            this.Boyer_Moore.Location = new System.Drawing.Point(0, 195);
            this.Boyer_Moore.Name = "Boyer_Moore";
            this.Boyer_Moore.Size = new System.Drawing.Size(209, 43);
            this.Boyer_Moore.TabIndex = 4;
            this.Boyer_Moore.Text = "Boyer-Moore";
            this.Boyer_Moore.UseVisualStyleBackColor = false;
            this.Boyer_Moore.Click += new System.EventHandler(this.Boyer_Moore_Click);
            // 
            // KMp
            // 
            this.KMp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.KMp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KMp.Dock = System.Windows.Forms.DockStyle.Top;
            this.KMp.FlatAppearance.BorderSize = 0;
            this.KMp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KMp.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.KMp.ForeColor = System.Drawing.Color.White;
            this.KMp.Location = new System.Drawing.Point(0, 152);
            this.KMp.Name = "KMp";
            this.KMp.Size = new System.Drawing.Size(209, 43);
            this.KMp.TabIndex = 3;
            this.KMp.Text = "KMP";
            this.KMp.UseVisualStyleBackColor = false;
            this.KMp.Click += new System.EventHandler(this.KMP_Click);
            // 
            // Rabin_Karp
            // 
            this.Rabin_Karp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Rabin_Karp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rabin_Karp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Rabin_Karp.FlatAppearance.BorderSize = 0;
            this.Rabin_Karp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rabin_Karp.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Rabin_Karp.ForeColor = System.Drawing.Color.White;
            this.Rabin_Karp.Location = new System.Drawing.Point(0, 109);
            this.Rabin_Karp.Name = "Rabin_Karp";
            this.Rabin_Karp.Size = new System.Drawing.Size(209, 43);
            this.Rabin_Karp.TabIndex = 2;
            this.Rabin_Karp.Text = "Rabin-Karp";
            this.Rabin_Karp.UseVisualStyleBackColor = false;
            this.Rabin_Karp.Click += new System.EventHandler(this.Rabin_Karp_Click);
            // 
            // Força_Bruta
            // 
            this.Força_Bruta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Força_Bruta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Força_Bruta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Força_Bruta.FlatAppearance.BorderSize = 0;
            this.Força_Bruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Força_Bruta.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Força_Bruta.ForeColor = System.Drawing.Color.White;
            this.Força_Bruta.Location = new System.Drawing.Point(0, 66);
            this.Força_Bruta.Name = "Força_Bruta";
            this.Força_Bruta.Size = new System.Drawing.Size(209, 43);
            this.Força_Bruta.TabIndex = 1;
            this.Força_Bruta.Text = "Força Bruta";
            this.Força_Bruta.UseVisualStyleBackColor = false;
            this.Força_Bruta.Click += new System.EventHandler(this.Força_Bruta_Click);
            // 
            // Pesquisar
            // 
            this.Pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pesquisar.FlatAppearance.BorderSize = 0;
            this.Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisar.ForeColor = System.Drawing.Color.White;
            this.Pesquisar.Image = global::BuscaTexto.Properties.Resources.Expand_Arrow_20px;
            this.Pesquisar.Location = new System.Drawing.Point(0, 0);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(209, 66);
            this.Pesquisar.TabIndex = 0;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pesquisar.UseVisualStyleBackColor = false;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // panelDropDown3
            // 
            this.panelDropDown3.Controls.Add(this.Sobre);
            this.panelDropDown3.Controls.Add(this.Ajuda);
            this.panelDropDown3.Location = new System.Drawing.Point(3, 147);
            this.panelDropDown3.MaximumSize = new System.Drawing.Size(209, 111);
            this.panelDropDown3.MinimumSize = new System.Drawing.Size(209, 66);
            this.panelDropDown3.Name = "panelDropDown3";
            this.panelDropDown3.Size = new System.Drawing.Size(209, 66);
            this.panelDropDown3.TabIndex = 5;
            // 
            // Sobre
            // 
            this.Sobre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sobre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sobre.FlatAppearance.BorderSize = 0;
            this.Sobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sobre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sobre.ForeColor = System.Drawing.Color.White;
            this.Sobre.Location = new System.Drawing.Point(0, 66);
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(209, 43);
            this.Sobre.TabIndex = 5;
            this.Sobre.Text = "Sobre...";
            this.Sobre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Sobre.UseVisualStyleBackColor = false;
            this.Sobre.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // Ajuda
            // 
            this.Ajuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Ajuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ajuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ajuda.FlatAppearance.BorderSize = 0;
            this.Ajuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajuda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajuda.ForeColor = System.Drawing.Color.White;
            this.Ajuda.Image = global::BuscaTexto.Properties.Resources.Expand_Arrow_20px;
            this.Ajuda.Location = new System.Drawing.Point(0, 0);
            this.Ajuda.Name = "Ajuda";
            this.Ajuda.Size = new System.Drawing.Size(209, 66);
            this.Ajuda.TabIndex = 4;
            this.Ajuda.Text = "Ajuda";
            this.Ajuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ajuda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Ajuda.UseVisualStyleBackColor = false;
            this.Ajuda.Click += new System.EventHandler(this.Ajuda_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Interval = 15;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 641);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.texto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Trabalho Prático - Busca em Texto 2020.1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
            this.panelDropDown2.ResumeLayout(false);
            this.panelDropDown3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Abrir;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Arquivo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelDropDown2;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.Button Boyer_Moore;
        private System.Windows.Forms.Button KMp;
        private System.Windows.Forms.Button Rabin_Karp;
        private System.Windows.Forms.Button Força_Bruta;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Ajuda;
        private System.Windows.Forms.Panel panelDropDown3;
        private System.Windows.Forms.Button Sobre;
        private System.Windows.Forms.Timer timer3;
    }
}

