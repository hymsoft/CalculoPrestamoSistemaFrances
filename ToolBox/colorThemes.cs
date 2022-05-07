using System.Drawing;

namespace ToolBox
{
    class ColorThemes
    {
        public static Color PanelPrincipal;
        public static Color PanelMenu;
        public static Color PanelTitulo;
        public static Color FuenteIconos;
        public static Color BtnWindows;

        //Color por defecto
        private static readonly Color PanelPrincipalD = Color.FromArgb(49,66,82);
        private static readonly Color PanelMenuD = Color.FromArgb(26,32,40);
        private static readonly Color PanelTituloD = Color.FromArgb(0,80,200);
        private static readonly Color FuenteIconosD = Color.FromArgb(154,235,163);
        private static readonly Color BtnWindowsD = Color.FromArgb(255,255,255);

        //Tema Morado
        private static readonly Color PanelPrincipalM = Color.FromArgb(92,36,97);
        private static readonly Color PanelMenuM = Color.FromArgb(94,65,97);
        private static readonly Color PanelTituloM = Color.FromArgb(164,65,173);
        private static readonly Color FuenteIconosM = Color.FromArgb(255, 255, 255);
        private static readonly Color BtnWindowsM = Color.FromArgb(255, 255, 255);


        //Seleccionar Colores
        #region -> Metodos
        public static void ElegirTema(string Tema)
        {
            if(Tema == "Defecto")
            {
                PanelPrincipal = PanelPrincipalD;
                PanelMenu = PanelMenuD;
                PanelTitulo = PanelTituloD;
                FuenteIconos = FuenteIconosD;
                BtnWindows = BtnWindowsD;
            }
            if (Tema == "Morado")
            {
                PanelPrincipal = PanelPrincipalM;
                PanelMenu = PanelMenuM;
                PanelTitulo = PanelTituloM;
                FuenteIconos = FuenteIconosM;
                BtnWindows = BtnWindowsM;
            }

        }
        #endregion

    }
}
