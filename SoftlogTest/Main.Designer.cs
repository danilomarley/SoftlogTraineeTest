namespace SoftlogTest
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.brtInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(13, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // brtInfo
            // 
            this.brtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brtInfo.Location = new System.Drawing.Point(341, 321);
            this.brtInfo.Name = "brtInfo";
            this.brtInfo.Size = new System.Drawing.Size(118, 37);
            this.brtInfo.TabIndex = 2;
            this.brtInfo.Text = "Informações";
            this.brtInfo.UseVisualStyleBackColor = true;
            this.brtInfo.Click += new System.EventHandler(this.brtInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de produtos";
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.AllowUserToAddRows = false;
            this.gridViewProduct.AllowUserToDeleteRows = false;
            this.gridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProduct.Location = new System.Drawing.Point(12, 83);
            this.gridViewProduct.Name = "gridViewProduct";
            this.gridViewProduct.Size = new System.Drawing.Size(447, 232);
            this.gridViewProduct.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 370);
            this.Controls.Add(this.gridViewProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brtInfo);
            this.Controls.Add(this.btnAdd);
            this.Name = "Main";
            this.Text = "Softlog - Teste";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button brtInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewProduct;
    }
}

