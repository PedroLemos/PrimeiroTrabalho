﻿namespace Trabalho1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCadFilme = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelCadData = new System.Windows.Forms.Label();
            this.labelCadLocal = new System.Windows.Forms.Label();
            this.labelCadGenero = new System.Windows.Forms.Label();
            this.labelCadNome = new System.Windows.Forms.Label();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadCadastrar = new System.Windows.Forms.Button();
            this.comboBoxCadGenero = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCadData = new System.Windows.Forms.DateTimePicker();
            this.textBoxCadLocal = new System.Windows.Forms.TextBox();
            this.tabPageBusca = new System.Windows.Forms.TabPage();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerBuscaData2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBuscaData1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxBuscaLocal = new System.Windows.Forms.TextBox();
            this.comboBoxBuscaGenero = new System.Windows.Forms.ComboBox();
            this.textBoxBuscaNome = new System.Windows.Forms.TextBox();
            this.checkBoxBuscaData = new System.Windows.Forms.CheckBox();
            this.checkBoxBuscaLocal = new System.Windows.Forms.CheckBox();
            this.checkBoxBuscaGenero = new System.Windows.Forms.CheckBox();
            this.checkBoxBuscaNome = new System.Windows.Forms.CheckBox();
            this.listViewDados = new System.Windows.Forms.ListView();
            this.columnNomeFilme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocalAssistido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDataAssistida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.tabPageBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gênero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Assistida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Local Assistido";
            // 
            // textBoxCadFilme
            // 
            this.textBoxCadFilme.Location = new System.Drawing.Point(22, 23);
            this.textBoxCadFilme.Name = "textBoxCadFilme";
            this.textBoxCadFilme.Size = new System.Drawing.Size(308, 20);
            this.textBoxCadFilme.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCadastro);
            this.tabControl1.Controls.Add(this.tabPageBusca);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 216);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.buttonCancelar);
            this.tabPageCadastro.Controls.Add(this.buttonSalvar);
            this.tabPageCadastro.Controls.Add(this.labelCadData);
            this.tabPageCadastro.Controls.Add(this.labelCadLocal);
            this.tabPageCadastro.Controls.Add(this.labelCadGenero);
            this.tabPageCadastro.Controls.Add(this.labelCadNome);
            this.tabPageCadastro.Controls.Add(this.buttonRemover);
            this.tabPageCadastro.Controls.Add(this.buttonEditar);
            this.tabPageCadastro.Controls.Add(this.buttonCadCadastrar);
            this.tabPageCadastro.Controls.Add(this.comboBoxCadGenero);
            this.tabPageCadastro.Controls.Add(this.dateTimePickerCadData);
            this.tabPageCadastro.Controls.Add(this.textBoxCadLocal);
            this.tabPageCadastro.Controls.Add(this.label2);
            this.tabPageCadastro.Controls.Add(this.label4);
            this.tabPageCadastro.Controls.Add(this.textBoxCadFilme);
            this.tabPageCadastro.Controls.Add(this.label3);
            this.tabPageCadastro.Controls.Add(this.label1);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(520, 190);
            this.tabPageCadastro.TabIndex = 0;
            this.tabPageCadastro.Text = "Cadastro";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(112, 152);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(22, 151);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 8;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Visible = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelCadData
            // 
            this.labelCadData.AutoSize = true;
            this.labelCadData.Location = new System.Drawing.Point(377, 109);
            this.labelCadData.Name = "labelCadData";
            this.labelCadData.Size = new System.Drawing.Size(41, 13);
            this.labelCadData.TabIndex = 15;
            this.labelCadData.Text = "label10";
            this.labelCadData.Visible = false;
            // 
            // labelCadLocal
            // 
            this.labelCadLocal.AutoSize = true;
            this.labelCadLocal.Location = new System.Drawing.Point(22, 108);
            this.labelCadLocal.Name = "labelCadLocal";
            this.labelCadLocal.Size = new System.Drawing.Size(35, 13);
            this.labelCadLocal.TabIndex = 14;
            this.labelCadLocal.Text = "label9";
            this.labelCadLocal.Visible = false;
            // 
            // labelCadGenero
            // 
            this.labelCadGenero.AutoSize = true;
            this.labelCadGenero.Location = new System.Drawing.Point(377, 44);
            this.labelCadGenero.Name = "labelCadGenero";
            this.labelCadGenero.Size = new System.Drawing.Size(35, 13);
            this.labelCadGenero.TabIndex = 13;
            this.labelCadGenero.Text = "label8";
            this.labelCadGenero.Visible = false;
            // 
            // labelCadNome
            // 
            this.labelCadNome.AutoSize = true;
            this.labelCadNome.Location = new System.Drawing.Point(22, 43);
            this.labelCadNome.Name = "labelCadNome";
            this.labelCadNome.Size = new System.Drawing.Size(35, 13);
            this.labelCadNome.TabIndex = 12;
            this.labelCadNome.Text = "label7";
            this.labelCadNome.Visible = false;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(423, 152);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 7;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(332, 152);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 6;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCadCadastrar
            // 
            this.buttonCadCadastrar.Location = new System.Drawing.Point(241, 152);
            this.buttonCadCadastrar.Name = "buttonCadCadastrar";
            this.buttonCadCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadCadastrar.TabIndex = 5;
            this.buttonCadCadastrar.Text = "Cadastrar";
            this.buttonCadCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadCadastrar.Click += new System.EventHandler(this.buttonCadCadastrar_Click);
            // 
            // comboBoxCadGenero
            // 
            this.comboBoxCadGenero.FormattingEnabled = true;
            this.comboBoxCadGenero.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentario",
            "Infantil",
            "Romance",
            "Ficção Ciêntifica"});
            this.comboBoxCadGenero.Location = new System.Drawing.Point(377, 23);
            this.comboBoxCadGenero.Name = "comboBoxCadGenero";
            this.comboBoxCadGenero.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCadGenero.TabIndex = 2;
            // 
            // dateTimePickerCadData
            // 
            this.dateTimePickerCadData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCadData.Location = new System.Drawing.Point(377, 88);
            this.dateTimePickerCadData.Name = "dateTimePickerCadData";
            this.dateTimePickerCadData.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerCadData.TabIndex = 4;
            // 
            // textBoxCadLocal
            // 
            this.textBoxCadLocal.Location = new System.Drawing.Point(22, 88);
            this.textBoxCadLocal.Name = "textBoxCadLocal";
            this.textBoxCadLocal.Size = new System.Drawing.Size(308, 20);
            this.textBoxCadLocal.TabIndex = 3;
            // 
            // tabPageBusca
            // 
            this.tabPageBusca.Controls.Add(this.buttonPesquisar);
            this.tabPageBusca.Controls.Add(this.label6);
            this.tabPageBusca.Controls.Add(this.label5);
            this.tabPageBusca.Controls.Add(this.dateTimePickerBuscaData2);
            this.tabPageBusca.Controls.Add(this.dateTimePickerBuscaData1);
            this.tabPageBusca.Controls.Add(this.textBoxBuscaLocal);
            this.tabPageBusca.Controls.Add(this.comboBoxBuscaGenero);
            this.tabPageBusca.Controls.Add(this.textBoxBuscaNome);
            this.tabPageBusca.Controls.Add(this.checkBoxBuscaData);
            this.tabPageBusca.Controls.Add(this.checkBoxBuscaLocal);
            this.tabPageBusca.Controls.Add(this.checkBoxBuscaGenero);
            this.tabPageBusca.Controls.Add(this.checkBoxBuscaNome);
            this.tabPageBusca.Location = new System.Drawing.Point(4, 22);
            this.tabPageBusca.Name = "tabPageBusca";
            this.tabPageBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusca.Size = new System.Drawing.Size(520, 190);
            this.tabPageBusca.TabIndex = 1;
            this.tabPageBusca.Text = "Busca";
            this.tabPageBusca.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(423, 110);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 10;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "até";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "De";
            // 
            // dateTimePickerBuscaData2
            // 
            this.dateTimePickerBuscaData2.Enabled = false;
            this.dateTimePickerBuscaData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBuscaData2.Location = new System.Drawing.Point(419, 81);
            this.dateTimePickerBuscaData2.Name = "dateTimePickerBuscaData2";
            this.dateTimePickerBuscaData2.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerBuscaData2.TabIndex = 9;
            // 
            // dateTimePickerBuscaData1
            // 
            this.dateTimePickerBuscaData1.Enabled = false;
            this.dateTimePickerBuscaData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBuscaData1.Location = new System.Drawing.Point(306, 81);
            this.dateTimePickerBuscaData1.Name = "dateTimePickerBuscaData1";
            this.dateTimePickerBuscaData1.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerBuscaData1.TabIndex = 8;
            // 
            // textBoxBuscaLocal
            // 
            this.textBoxBuscaLocal.Enabled = false;
            this.textBoxBuscaLocal.Location = new System.Drawing.Point(19, 81);
            this.textBoxBuscaLocal.Name = "textBoxBuscaLocal";
            this.textBoxBuscaLocal.Size = new System.Drawing.Size(215, 20);
            this.textBoxBuscaLocal.TabIndex = 6;
            // 
            // comboBoxBuscaGenero
            // 
            this.comboBoxBuscaGenero.Enabled = false;
            this.comboBoxBuscaGenero.FormattingEnabled = true;
            this.comboBoxBuscaGenero.Location = new System.Drawing.Point(282, 27);
            this.comboBoxBuscaGenero.Name = "comboBoxBuscaGenero";
            this.comboBoxBuscaGenero.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuscaGenero.TabIndex = 4;
            // 
            // textBoxBuscaNome
            // 
            this.textBoxBuscaNome.Enabled = false;
            this.textBoxBuscaNome.Location = new System.Drawing.Point(19, 27);
            this.textBoxBuscaNome.Name = "textBoxBuscaNome";
            this.textBoxBuscaNome.Size = new System.Drawing.Size(215, 20);
            this.textBoxBuscaNome.TabIndex = 2;
            // 
            // checkBoxBuscaData
            // 
            this.checkBoxBuscaData.AutoSize = true;
            this.checkBoxBuscaData.Location = new System.Drawing.Point(282, 62);
            this.checkBoxBuscaData.Name = "checkBoxBuscaData";
            this.checkBoxBuscaData.Size = new System.Drawing.Size(93, 17);
            this.checkBoxBuscaData.TabIndex = 7;
            this.checkBoxBuscaData.Text = "Data Assistida";
            this.checkBoxBuscaData.UseVisualStyleBackColor = true;
            this.checkBoxBuscaData.CheckedChanged += new System.EventHandler(this.checkBoxBuscaData_CheckedChanged);
            // 
            // checkBoxBuscaLocal
            // 
            this.checkBoxBuscaLocal.AutoSize = true;
            this.checkBoxBuscaLocal.Location = new System.Drawing.Point(19, 62);
            this.checkBoxBuscaLocal.Name = "checkBoxBuscaLocal";
            this.checkBoxBuscaLocal.Size = new System.Drawing.Size(96, 17);
            this.checkBoxBuscaLocal.TabIndex = 5;
            this.checkBoxBuscaLocal.Text = "Local Assistido";
            this.checkBoxBuscaLocal.UseVisualStyleBackColor = true;
            this.checkBoxBuscaLocal.CheckedChanged += new System.EventHandler(this.checkBoxBuscaLocal_CheckedChanged);
            // 
            // checkBoxBuscaGenero
            // 
            this.checkBoxBuscaGenero.AutoSize = true;
            this.checkBoxBuscaGenero.Location = new System.Drawing.Point(282, 9);
            this.checkBoxBuscaGenero.Name = "checkBoxBuscaGenero";
            this.checkBoxBuscaGenero.Size = new System.Drawing.Size(61, 17);
            this.checkBoxBuscaGenero.TabIndex = 3;
            this.checkBoxBuscaGenero.Text = "Gênero";
            this.checkBoxBuscaGenero.UseVisualStyleBackColor = true;
            this.checkBoxBuscaGenero.CheckedChanged += new System.EventHandler(this.checkBoxBuscaGenero_CheckedChanged);
            // 
            // checkBoxBuscaNome
            // 
            this.checkBoxBuscaNome.AutoSize = true;
            this.checkBoxBuscaNome.Location = new System.Drawing.Point(19, 9);
            this.checkBoxBuscaNome.Name = "checkBoxBuscaNome";
            this.checkBoxBuscaNome.Size = new System.Drawing.Size(96, 17);
            this.checkBoxBuscaNome.TabIndex = 1;
            this.checkBoxBuscaNome.Text = "Nome do Filme";
            this.checkBoxBuscaNome.UseVisualStyleBackColor = true;
            this.checkBoxBuscaNome.CheckedChanged += new System.EventHandler(this.checkBoxBuscaNome_CheckedChanged);
            // 
            // listViewDados
            // 
            this.listViewDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNomeFilme,
            this.columnGenero,
            this.columnLocalAssistido,
            this.columnDataAssistida});
            this.listViewDados.FullRowSelect = true;
            this.listViewDados.Location = new System.Drawing.Point(12, 234);
            this.listViewDados.Name = "listViewDados";
            this.listViewDados.Size = new System.Drawing.Size(528, 213);
            this.listViewDados.TabIndex = 6;
            this.listViewDados.UseCompatibleStateImageBehavior = false;
            this.listViewDados.View = System.Windows.Forms.View.Details;
            this.listViewDados.SelectedIndexChanged += new System.EventHandler(this.listViewDados_SelectedIndexChanged);
            // 
            // columnNomeFilme
            // 
            this.columnNomeFilme.Text = "Nome do Filme";
            this.columnNomeFilme.Width = 215;
            // 
            // columnGenero
            // 
            this.columnGenero.Text = "Gênero";
            this.columnGenero.Width = 95;
            // 
            // columnLocalAssistido
            // 
            this.columnLocalAssistido.Text = "Local Assistido";
            this.columnLocalAssistido.Width = 134;
            // 
            // columnDataAssistida
            // 
            this.columnDataAssistida.Text = "Data Assistida";
            this.columnDataAssistida.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 459);
            this.Controls.Add(this.listViewDados);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.tabPageBusca.ResumeLayout(false);
            this.tabPageBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCadFilme;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.DateTimePicker dateTimePickerCadData;
        private System.Windows.Forms.TextBox textBoxCadLocal;
        private System.Windows.Forms.TabPage tabPageBusca;
        private System.Windows.Forms.ComboBox comboBoxCadGenero;
        private System.Windows.Forms.Button buttonCadCadastrar;
        private System.Windows.Forms.CheckBox checkBoxBuscaData;
        private System.Windows.Forms.CheckBox checkBoxBuscaLocal;
        private System.Windows.Forms.CheckBox checkBoxBuscaGenero;
        private System.Windows.Forms.CheckBox checkBoxBuscaNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerBuscaData2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBuscaData1;
        private System.Windows.Forms.TextBox textBoxBuscaLocal;
        private System.Windows.Forms.ComboBox comboBoxBuscaGenero;
        private System.Windows.Forms.TextBox textBoxBuscaNome;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.ListView listViewDados;
        private System.Windows.Forms.ColumnHeader columnNomeFilme;
        private System.Windows.Forms.ColumnHeader columnGenero;
        private System.Windows.Forms.ColumnHeader columnLocalAssistido;
        private System.Windows.Forms.ColumnHeader columnDataAssistida;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelCadData;
        private System.Windows.Forms.Label labelCadLocal;
        private System.Windows.Forms.Label labelCadGenero;
        private System.Windows.Forms.Label labelCadNome;
    }
}

