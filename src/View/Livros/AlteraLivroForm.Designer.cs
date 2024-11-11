using System.ComponentModel;

namespace POO_II_NP2_WinForms.View.Livros;

partial class AlteraLivroForm
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
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnSalvar = new System.Windows.Forms.Button();
        this.txtEditora = new System.Windows.Forms.TextBox();
        this.lblEditora = new System.Windows.Forms.Label();
        this.txtGenero = new System.Windows.Forms.TextBox();
        this.lblGenero = new System.Windows.Forms.Label();
        this.txtAutor = new System.Windows.Forms.TextBox();
        this.lblAutor = new System.Windows.Forms.Label();
        this.txtTitulo = new System.Windows.Forms.TextBox();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.txtId = new System.Windows.Forms.TextBox();
        this.lblId = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // btnCancelar
        // 
        this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancelar.Location = new System.Drawing.Point(601, 457);
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.Size = new System.Drawing.Size(179, 36);
        this.btnCancelar.TabIndex = 19;
        this.btnCancelar.Text = "Fechar";
        this.btnCancelar.UseVisualStyleBackColor = true;
        this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        // 
        // btnSalvar
        // 
        this.btnSalvar.Location = new System.Drawing.Point(383, 457);
        this.btnSalvar.Name = "btnSalvar";
        this.btnSalvar.Size = new System.Drawing.Size(179, 36);
        this.btnSalvar.TabIndex = 18;
        this.btnSalvar.Text = "Salvar";
        this.btnSalvar.UseVisualStyleBackColor = true;
        this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        // 
        // txtEditora
        // 
        this.txtEditora.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtEditora.Location = new System.Drawing.Point(513, 351);
        this.txtEditora.Name = "txtEditora";
        this.txtEditora.Size = new System.Drawing.Size(267, 27);
        this.txtEditora.TabIndex = 17;
        // 
        // lblEditora
        // 
        this.lblEditora.BackColor = System.Drawing.SystemColors.Control;
        this.lblEditora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblEditora.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblEditora.Location = new System.Drawing.Point(383, 351);
        this.lblEditora.Name = "lblEditora";
        this.lblEditora.Size = new System.Drawing.Size(124, 27);
        this.lblEditora.TabIndex = 16;
        this.lblEditora.Text = "Editora";
        this.lblEditora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtGenero
        // 
        this.txtGenero.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtGenero.Location = new System.Drawing.Point(513, 318);
        this.txtGenero.Name = "txtGenero";
        this.txtGenero.Size = new System.Drawing.Size(267, 27);
        this.txtGenero.TabIndex = 15;
        // 
        // lblGenero
        // 
        this.lblGenero.BackColor = System.Drawing.SystemColors.Control;
        this.lblGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.lblGenero.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblGenero.Location = new System.Drawing.Point(383, 318);
        this.lblGenero.Name = "lblGenero";
        this.lblGenero.Size = new System.Drawing.Size(124, 27);
        this.lblGenero.TabIndex = 14;
        this.lblGenero.Text = "Gênero";
        this.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtAutor
        // 
        this.txtAutor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtAutor.Location = new System.Drawing.Point(513, 285);
        this.txtAutor.Name = "txtAutor";
        this.txtAutor.Size = new System.Drawing.Size(267, 27);
        this.txtAutor.TabIndex = 13;
        // 
        // lblAutor
        // 
        this.lblAutor.BackColor = System.Drawing.SystemColors.Control;
        this.lblAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblAutor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblAutor.Location = new System.Drawing.Point(383, 285);
        this.lblAutor.Name = "lblAutor";
        this.lblAutor.Size = new System.Drawing.Size(124, 27);
        this.lblAutor.TabIndex = 12;
        this.lblAutor.Text = "Autor";
        this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtTitulo
        // 
        this.txtTitulo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtTitulo.Location = new System.Drawing.Point(513, 252);
        this.txtTitulo.Name = "txtTitulo";
        this.txtTitulo.Size = new System.Drawing.Size(267, 27);
        this.txtTitulo.TabIndex = 11;
        // 
        // lblTitulo
        // 
        this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
        this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblTitulo.Location = new System.Drawing.Point(383, 252);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(124, 27);
        this.lblTitulo.TabIndex = 10;
        this.lblTitulo.Text = "Título";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtId
        // 
        this.txtId.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtId.Location = new System.Drawing.Point(513, 31);
        this.txtId.Name = "txtId";
        this.txtId.ReadOnly = true;
        this.txtId.Size = new System.Drawing.Size(267, 27);
        this.txtId.TabIndex = 21;
        // 
        // lblId
        // 
        this.lblId.BackColor = System.Drawing.SystemColors.Control;
        this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblId.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblId.Location = new System.Drawing.Point(383, 31);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(124, 27);
        this.lblId.TabIndex = 20;
        this.lblId.Text = "ID";
        this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // AlteraLivroForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.ClientSize = new System.Drawing.Size(1350, 681);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblId);
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
        this.Name = "AlteraLivroForm";
        this.ShowIcon = false;
        this.Text = "AlteraLivroForm";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.AlteraLivroForm_Load);
        this.ResizeBegin += new System.EventHandler(this.ResizeForm);
        this.ResizeEnd += new System.EventHandler(this.ResizeForm);
        this.SizeChanged += new System.EventHandler(this.ResizeForm);
        this.Resize += new System.EventHandler(this.ResizeForm);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.Label lblId;

    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.TextBox txtEditora;
    private System.Windows.Forms.Label lblEditora;
    private System.Windows.Forms.TextBox txtGenero;
    private System.Windows.Forms.Label lblGenero;
    private System.Windows.Forms.TextBox txtAutor;
    private System.Windows.Forms.Label lblAutor;
    private System.Windows.Forms.TextBox txtTitulo;
    private System.Windows.Forms.Label lblTitulo;

    #endregion
}