namespace capaPresentacion
{
    partial class inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.sistema = new System.Windows.Forms.Label();
            this.menuusuario = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.iconMenuItem4,
            this.iconMenuItem3,
            this.iconMenuItem2,
            this.iconMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 86);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1176, 91);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1176, 86);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // sistema
            // 
            this.sistema.AutoSize = true;
            this.sistema.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sistema.Location = new System.Drawing.Point(12, 22);
            this.sistema.Name = "sistema";
            this.sistema.Size = new System.Drawing.Size(319, 37);
            this.sistema.TabIndex = 2;
            this.sistema.Text = "Operaciones Indokca";
            // 
            // menuusuario
            // 
            this.menuusuario.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuusuario.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.menuusuario.IconColor = System.Drawing.Color.Black;
            this.menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(125, 87);
            this.menuusuario.Text = "Usuarios";
            this.menuusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(132, 87);
            this.iconMenuItem1.Text = "Buscador";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(302, 87);
            this.iconMenuItem2.Text = "Registro de Operaciones";
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(229, 87);
            this.iconMenuItem3.Text = "Registro de tareas";
            this.iconMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(140, 87);
            this.iconMenuItem4.Text = "Inventario";
            this.iconMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 599);
            this.Controls.Add(this.sistema);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label sistema;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}

