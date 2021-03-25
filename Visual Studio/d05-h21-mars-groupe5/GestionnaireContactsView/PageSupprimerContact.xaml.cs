﻿using System;
using System.Windows;
using System.Windows.Controls;
using GestionnaireContactsBLL;

namespace GestionnaireContactsView
{

    /// <summary>
    /// Interaction logic for PageSupprimerContact.xaml
    /// </summary>

    public partial class PageSupprimerContact : Page
    {

        public PageSupprimerContact()
        {
            InitializeComponent();
        }

        //Bouton pour supprimer les informations dans la base de données
        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(BLL.Supprimer(int.Parse(txtId.Text)));
                this.txtId.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("L'ID doit être un nombre!");
            }
        }

        //Bouton retour
        private void BtnRetour(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MenuPrincipalGestionnaire());
        }

    }

}