using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rtorresS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage(string usuario, string contraseña)
        {
            InitializeComponent();
            lblUsuario.Text = "El usuario conectado es " + usuario +"la contraseña es"+ contraseña;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNotaMomento1.Text))
            {
                if (!String.IsNullOrEmpty(txtNotaExamenMomento1.Text))
                {
                    double notasm1 = (Convert.ToDouble(txtNotaMomento1.Text) * 0.3);
                    double notaExamen = (Convert.ToDouble(txtNotaExamenMomento1.Text) * 0.2);
                    double totalM1 = notasm1 + notaExamen;
                    txtNotaParcialMomento1.Text = totalM1.ToString();




                }
                else
                {
                    DisplayAlert("Alerta", " Ingresar la Nota de Examen Parcial 1", "Salir");
                }
            }
            else
            {
                DisplayAlert("Alerta", "Ingresar la Nota de Seguimiento Parcial 1", "Salir");
            }
        }

        private void btnCalcularP2_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNotaMomento2.Text))
            {
                if (!String.IsNullOrEmpty(txtNotaExamenMomento2.Text))
                {
                    double notasm2 = (Convert.ToDouble(txtNotaMomento2.Text) * 0.3);
                    double notaExamen = (Convert.ToDouble(txtNotaExamenMomento2.Text) * 0.2);
                    double totalm2 = notasm2 + notaExamen;
                    txtNotaParcialMomento2.Text = totalm2.ToString();

                   
                }
                else
                {
                    DisplayAlert("Alerta", " Ingresar la Nota de Examen Parcial Momento  2", "Salir");
                }
            }
            else
            {
                DisplayAlert("Alerta", " Ingresar la Nota de Seguimiento Parcial Momento  2", "Salir");
            }
        }

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry ent = (sender as Entry);
            if (!String.IsNullOrEmpty(ent.Text))
            {
                int valor = Convert.ToInt32(ent.Text);

                if (valor < 1 || valor > 10)
                {
                    DisplayAlert("Alerta", "El valor debe estar en el rango de  1 y 10", "Salir");
                    ent.Focus();
                    ent.Text = String.Empty;
                }
            }


        }

        private void btnpromedio_Clicked(object sender, EventArgs e)
        {

            double nota1_m1 = (Convert.ToDouble(txtNotaMomento1.Text) * 0.3);
            double nota1_e1 = (Convert.ToDouble(txtNotaExamenMomento1.Text) * 0.2);       
            double total_m1 = nota1_m1 + nota1_e1;

            double nota1_m2 = (Convert.ToDouble(txtNotaMomento2.Text) * 0.3);
            double nota1_e2 = (Convert.ToDouble(txtNotaExamenMomento2.Text) * 0.2);
            double total_m2 = nota1_m2 + nota1_e2;

            double total_final = total_m2+ total_m1;

           // DisplayAlert("Alerta","El valor es:"+ total_final, "Aceptar");

            if (total_final >= 7)
            {


                DisplayAlert("Alerta", " APROBADO CON  :" + total_final, "Salir");
            }
            else if (total_final >= 5 && total_final<7)
            {
                DisplayAlert("Alerta", "COMPLEMENTARIO CON :" + total_final, "Salir");
            }
            else
            {
                DisplayAlert("Alerta", "REPROBADO CON :" + total_final, "Salir");
            }
        }
    }
}



