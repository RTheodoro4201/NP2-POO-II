using System.ComponentModel;

namespace POO_II_NP2_WinForms.View.Livros;

partial class ExcluirLivroForm
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
        this.txtId = new System.Windows.Forms.TextBox();
        this.lblId = new System.Windows.Forms.Label();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.txtEditora = new System.Windows.Forms.TextBox();
        this.lblEditora = new System.Windows.Forms.Label();
        this.txtGenero = new System.Windows.Forms.TextBox();
        this.lblGenero = new System.Windows.Forms.Label();
        this.txtAutor = new System.Windows.Forms.TextBox();
        this.lblAutor = new System.Windows.Forms.Label();
        this.txtTitulo = new System.Windows.Forms.TextBox();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.btnExcluir = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // txtId
        // 
        this.txtId.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtId.Location = new System.Drawing.Point(607, 113);
        this.txtId.Name = "txtId";
        this.txtId.ReadOnly = true;
        this.txtId.Size = new System.Drawing.Size(267, 27);
        this.txtId.TabIndex = 44;
        // 
        // lblId
        // 
        this.lblId.BackColor = System.Drawing.SystemColors.Control;
        this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblId.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblId.Location = new System.Drawing.Point(477, 113);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(124, 27);
        this.lblId.TabIndex = 43;
        this.lblId.Text = "ID";
        this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnCancelar
        // 
        this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
        this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 12F);
        this.btnCancelar.Location = new System.Drawing.Point(695, 533);
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.Size = new System.Drawing.Size(179, 36);
        this.btnCancelar.TabIndex = 42;
        this.btnCancelar.Text = "Cancelar";
        this.btnCancelar.UseVisualStyleBackColor = false;
        this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        // 
        // txtEditora
        // 
        this.txtEditora.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtEditora.Location = new System.Drawing.Point(607, 433);
        this.txtEditora.Name = "txtEditora";
        this.txtEditora.ReadOnly = true;
        this.txtEditora.Size = new System.Drawing.Size(267, 27);
        this.txtEditora.TabIndex = 41;
        // 
        // lblEditora
        // 
        this.lblEditora.BackColor = System.Drawing.SystemColors.Control;
        this.lblEditora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblEditora.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblEditora.Location = new System.Drawing.Point(477, 433);
        this.lblEditora.Name = "lblEditora";
        this.lblEditora.Size = new System.Drawing.Size(124, 27);
        this.lblEditora.TabIndex = 40;
        this.lblEditora.Text = "Editora";
        this.lblEditora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtGenero
        // 
        this.txtGenero.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtGenero.Location = new System.Drawing.Point(607, 400);
        this.txtGenero.Name = "txtGenero";
        this.txtGenero.ReadOnly = true;
        this.txtGenero.Size = new System.Drawing.Size(267, 27);
        this.txtGenero.TabIndex = 39;
        // 
        // lblGenero
        // 
        this.lblGenero.BackColor = System.Drawing.SystemColors.Control;
        this.lblGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.lblGenero.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblGenero.Location = new System.Drawing.Point(477, 400);
        this.lblGenero.Name = "lblGenero";
        this.lblGenero.Size = new System.Drawing.Size(124, 27);
        this.lblGenero.TabIndex = 38;
        this.lblGenero.Text = "Gênero";
        this.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtAutor
        // 
        this.txtAutor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtAutor.Location = new System.Drawing.Point(607, 367);
        this.txtAutor.Name = "txtAutor";
        this.txtAutor.ReadOnly = true;
        this.txtAutor.Size = new System.Drawing.Size(267, 27);
        this.txtAutor.TabIndex = 37;
        // 
        // lblAutor
        // 
        this.lblAutor.BackColor = System.Drawing.SystemColors.Control;
        this.lblAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblAutor.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblAutor.Location = new System.Drawing.Point(477, 367);
        this.lblAutor.Name = "lblAutor";
        this.lblAutor.Size = new System.Drawing.Size(124, 27);
        this.lblAutor.TabIndex = 36;
        this.lblAutor.Text = "Autor";
        this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtTitulo
        // 
        this.txtTitulo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.txtTitulo.Location = new System.Drawing.Point(607, 334);
        this.txtTitulo.Name = "txtTitulo";
        this.txtTitulo.ReadOnly = true;
        this.txtTitulo.Size = new System.Drawing.Size(267, 27);
        this.txtTitulo.TabIndex = 35;
        // 
        // lblTitulo
        // 
        this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
        this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F);
        this.lblTitulo.Location = new System.Drawing.Point(477, 334);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(124, 27);
        this.lblTitulo.TabIndex = 34;
        this.lblTitulo.Text = "Título";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnExcluir
        // 
        this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
        this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 12F);
        this.btnExcluir.Location = new System.Drawing.Point(477, 533);
        this.btnExcluir.Name = "btnExcluir";
        this.btnExcluir.Size = new System.Drawing.Size(179, 36);
        this.btnExcluir.TabIndex = 45;
        this.btnExcluir.Text = "Excluir";
        this.btnExcluir.UseVisualStyleBackColor = false;
        this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
        // 
        // ExcluirLivroForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.ClientSize = new System.Drawing.Size(1350, 681);
        this.Controls.Add(this.btnExcluir);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblId);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.txtEditora);
        this.Controls.Add(this.lblEditora);
        this.Controls.Add(this.txtGenero);
        this.Controls.Add(this.lblGenero);
        this.Controls.Add(this.txtAutor);
        this.Controls.Add(this.lblAutor);
        this.Controls.Add(this.txtTitulo);
        this.Controls.Add(this.lblTitulo);
        this.MinimumSize = new System.Drawing.Size(1364, 718);
        this.Name = "ExcluirLivroForm";
        this.ShowIcon = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.Text = "Excluir livro";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.ExcluirLivroForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button btnExcluir;

    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.Button btnCancelar;
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