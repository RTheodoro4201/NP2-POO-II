using System.ComponentModel;

namespace POO_II_NP2_WinForms.View.Livros;

partial class CadastroLivroForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.lblTitulo = new System.Windows.Forms.Label();
        this.txtTitulo = new System.Windows.Forms.TextBox();
        this.txtAutor = new System.Windows.Forms.TextBox();
        this.lblAutor = new System.Windows.Forms.Label();
        this.txtGenero = new System.Windows.Forms.TextBox();
        this.lblGenero = new System.Windows.Forms.Label();
        this.txtEditora = new System.Windows.Forms.TextBox();
        this.lblEditora = new System.Windows.Forms.Label();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // lblTitulo
        //
        this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblTitulo.Location = new System.Drawing.Point(403, 147);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(124, 27);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "Título";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // txtTitulo
        //
        this.txtTitulo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtTitulo.Location = new System.Drawing.Point(533, 147);
        this.txtTitulo.Name = "txtTitulo";
        this.txtTitulo.Size = new System.Drawing.Size(267, 27);
        this.txtTitulo.TabIndex = 1;
        //
        // txtAutor
        //
        this.txtAutor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtAutor.Location = new System.Drawing.Point(533, 180);
        this.txtAutor.Name = "txtAutor";
        this.txtAutor.Size = new System.Drawing.Size(267, 27);
        this.txtAutor.TabIndex = 3;
        //
        // lblAutor
        //
        this.lblAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblAutor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblAutor.Location = new System.Drawing.Point(403, 180);
        this.lblAutor.Name = "lblAutor";
        this.lblAutor.Size = new System.Drawing.Size(124, 27);
        this.lblAutor.TabIndex = 2;
        this.lblAutor.Text = "Autor";
        this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // txtGenero
        //
        this.txtGenero.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtGenero.Location = new System.Drawing.Point(533, 213);
        this.txtGenero.Name = "txtGenero";
        this.txtGenero.Size = new System.Drawing.Size(267, 27);
        this.txtGenero.TabIndex = 5;
        //
        // lblGenero
        //
        this.lblGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.lblGenero.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblGenero.Location = new System.Drawing.Point(403, 213);
        this.lblGenero.Name = "lblGenero";
        this.lblGenero.Size = new System.Drawing.Size(124, 27);
        this.lblGenero.TabIndex = 4;
        this.lblGenero.Text = "Gênero";
        this.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // txtEditora
        //
        this.txtEditora.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtEditora.Location = new System.Drawing.Point(533, 246);
        this.txtEditora.Name = "txtEditora";
        this.txtEditora.Size = new System.Drawing.Size(267, 27);
        this.txtEditora.TabIndex = 7;
        //
        // lblEditora
        //
        this.lblEditora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblEditora.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblEditora.Location = new System.Drawing.Point(403, 246);
        this.lblEditora.Name = "lblEditora";
        this.lblEditora.Size = new System.Drawing.Size(124, 27);
        this.lblEditora.TabIndex = 6;
        this.lblEditora.Text = "Editora";
        this.lblEditora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // btnSalvar
        //
        this.btnSalvar.Location = new System.Drawing.Point(403, 473);
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.Size = new System.Drawing.Size(179, 36);
        this.btnSalvar.TabIndex = 8;
        this.btnSalvar.Text = "Salvar";
        this.btnSalvar.UseVisualStyleBackColor = true;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        //
        // btnCancelar
        //
        this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancelar.Location = new System.Drawing.Point(621, 473);
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.Size = new System.Drawing.Size(179, 36);
        this.btnCancelar.TabIndex = 9;
        this.btnCancelar.Text = "Fechar";
        this.btnCancelar.UseVisualStyleBackColor = true;
        this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        //
        // CadastroLivroForm
        //
        this.AcceptButton = this.btnSalvar;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.btnCancelar;
        this.ClientSize = new System.Drawing.Size(1350, 681);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.txtEditora);
        this.Controls.Add(this.lblEditora);
        this.Controls.Add(this.txtGenero);
        this.Controls.Add(this.lblGenero);
        this.Controls.Add(this.txtAutor);
        this.Controls.Add(this.lblAutor);
        this.Controls.Add(this.txtTitulo);
        this.Controls.Add(this.lblTitulo);
        this.MaximizeBox = false;
        this.Name = "CadastroLivroForm";
        this.ShowIcon = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.Text = "Cadastrar Livros";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.Button btnCancelar;

    private System.Windows.Forms.Label lblAutor;
    private System.Windows.Forms.TextBox txtGenero;
    private System.Windows.Forms.Label lblGenero;
    private System.Windows.Forms.TextBox txtEditora;
    private System.Windows.Forms.Label lblEditora;

    private System.Windows.Forms.TextBox txtTitulo;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.TextBox txtAutor;

    #endregion
}