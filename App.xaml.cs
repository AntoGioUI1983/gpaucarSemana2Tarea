﻿namespace gpaucarSemana2Tarea
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Vistas.vPagina());
            
        }
    }
}
