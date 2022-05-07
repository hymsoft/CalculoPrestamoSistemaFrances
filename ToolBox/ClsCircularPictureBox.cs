using System;
//Para poder dibujar
using System.Drawing;
using System.Drawing.Drawing2D;
//Para poder usar los controles estandar
using System.Windows.Forms;
//Para implemetar atributos a las propiedades del control


namespace ToolBox
{
    class ClsCircularPictureBox : PictureBox
    {
        //Campos para el objeto personalizado
        //Tamaño del borde
        private int borderSize = 2;
        //Colores para el degrado
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        //Estilo del borde
        private DashStyle borderStyle = DashStyle.Solid;
        //Estilo de la capa del borde
        private DashCap borderCapStyle = DashCap.Flat;
        //Angulo del degrado
        private float gradientAngle = 50F;

        //Constructor
        public ClsCircularPictureBox()
        {
            //Tamaño del picturebox
            this.Size = new Size(100, 100);
            //Ajusto el tamaño de la imagen al tamaño del picturebox
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Descriptores de acceso de los campos para cambiar la apariencia desde el cuadro de controles
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                //Invalido para redibujar el control
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor2
        {
            get
            {
                return borderColor2;
            }

            set
            {
                borderColor2 = value;
                this.Invalidate();
            }
        }

        public DashStyle BorderStyle1
        {
            get
            {
                return borderStyle;
            }

            set
            {
                borderStyle = value;
                this.Invalidate();
            }
        }

        public DashCap BorderCapStyle
        {
            get
            {
                return borderCapStyle;
            }

            set
            {
                borderCapStyle = value;
                this.Invalidate();
            }
        }

        public float GradientAngle
        {
            get
            {
                return gradientAngle;
            }

            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }
        //Fin descriptores

        //Sobreescribo el metodo Resize del objeto, para que siempre tenga el mismo ancho que alto
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Width);
        }

        //Sobreesribo el metodo Paint para crear una apariencia personalizada
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //Propiedades para poder dibujar el nuevo objeto
            var graph = pe.Graphics;
            var rectangleContournSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectangleBorder = Rectangle.Inflate(rectangleContournSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectangleBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                penBorder.DashStyle = borderStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectangleContournSmooth);
                this.Region = new Region(pathRegion);
                graph.SmoothingMode = SmoothingMode.AntiAlias;

                //A dibujar el control!!!!
                graph.DrawEllipse(penSmooth, rectangleContournSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectangleBorder);
            }

        }
    }
}
