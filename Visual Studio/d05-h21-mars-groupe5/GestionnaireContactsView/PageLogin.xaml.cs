﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GestionnaireContactsBLL;
using GestionnaireContactsModele;
using GestionnaireContactsDAL;

namespace GestionnaireContactsView
{
    /// <summary>
    /// Interaction logic for PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        //Bouton retour
        private void BtnRetour_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MenuPrincipalGestionnaire());
        }

        //Bouton se connecter
        private void BtnConnecter_Click(object sender, RoutedEventArgs e)
        {
            Gestionnaire gestionnaire = new Gestionnaire()
            {
                Email = txtMail.Text,
                Password = pwdBox.Password
            };
            Administrateur administrateur = new Administrateur()
            {
                Email = txtMail.Text,
                Password = pwdBox.Password
            };

            if (BLL.ConnecterAdministrateur(administrateur) && comboBoxRole.SelectedIndex == 0)
            {
                MessageBox.Show("Bienvenue");
                this.NavigationService.Navigate(new PageAjouterContact());
            }
            else if (BLL.ConnecterGestionnaire(gestionnaire) && comboBoxRole.SelectedIndex == 1)
            {
                MessageBox.Show("Bienvenue");
                this.NavigationService.Navigate(new PageAjouterContact());
            }
            else
            {
                MessageBox.Show("Utilisateur non trouvé !");
            }
        }
    }
}
