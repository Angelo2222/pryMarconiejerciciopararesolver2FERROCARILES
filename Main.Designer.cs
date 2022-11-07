
namespace pryMarconiSP2
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDias = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.mrcCosto = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPrecioresultado = new System.Windows.Forms.Label();
            this.lblTotalresultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.mrcCosto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(12, 28);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "Dias";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(12, 87);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(51, 13);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Distancia";
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(115, 26);
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(120, 20);
            this.numDias.TabIndex = 2;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(115, 84);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(120, 20);
            this.txtDistancia.TabIndex = 3;
            // 
            // mrcCosto
            // 
            this.mrcCosto.Controls.Add(this.lblTotalresultado);
            this.mrcCosto.Controls.Add(this.lblPrecioresultado);
            this.mrcCosto.Controls.Add(this.lblTotal);
            this.mrcCosto.Controls.Add(this.lblPrecio);
            this.mrcCosto.Location = new System.Drawing.Point(15, 124);
            this.mrcCosto.Name = "mrcCosto";
            this.mrcCosto.Size = new System.Drawing.Size(285, 180);
            this.mrcCosto.TabIndex = 4;
            this.mrcCosto.TabStop = false;
            this.mrcCosto.Text = "Costo";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 113);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 60);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio";
            // 
            // lblPrecioresultado
            // 
            this.lblPrecioresultado.AutoSize = true;
            this.lblPrecioresultado.Location = new System.Drawing.Point(117, 60);
            this.lblPrecioresultado.Name = "lblPrecioresultado";
            this.lblPrecioresultado.Size = new System.Drawing.Size(0, 13);
            this.lblPrecioresultado.TabIndex = 2;
            // 
            // lblTotalresultado
            // 
            this.lblTotalresultado.AutoSize = true;
            this.lblTotalresultado.Location = new System.Drawing.Point(117, 113);
            this.lblTotalresultado.Name = "lblTotalresultado";
            this.lblTotalresultado.Size = new System.Drawing.Size(0, 13);
            this.lblTotalresultado.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(115, 327);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 362);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mrcCosto);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.numDias);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblDias);
            this.Name = "Main";
            this.Text = "Ferro-Calculo";
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.mrcCosto.ResumeLayout(false);
            this.mrcCosto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.GroupBox mrcCosto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTotalresultado;
        private System.Windows.Forms.Label lblPrecioresultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

